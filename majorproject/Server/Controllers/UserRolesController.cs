using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using majorproject.Shared.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using majorproject.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace majorproject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRolesController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRolesController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserRoleDto>>> GetUserRoles()
        {
            var userRoles = new List<UserRoleDto>();

            var users = _userManager.Users.ToList();
            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                foreach (var roleName in roles)
                {
                    var role = await _roleManager.FindByNameAsync(roleName);
                    userRoles.Add(new UserRoleDto
                    {
                        UserId = user.Id,
                        EmployeeID = user.EmployeeID,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Designation = user.Designation,
                        UserName = user.UserName,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        Password = user.PasswordHash,
                        RoleId = role.Id,
                        RoleName = role.Name
                    });
                }
            }

            return Ok(userRoles);
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<UserRoleDto>> GetUserRoleById(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var roles = await _userManager.GetRolesAsync(user);
            var role = roles.FirstOrDefault();
            var roleId = role != null ? (await _roleManager.FindByNameAsync(role)).Id : null;

            var userRoleDto = new UserRoleDto
            {
                UserId = user.Id,
                EmployeeID = user.EmployeeID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Designation = user.Designation,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                RoleId = roleId,
                RoleName = role
            };

            return Ok(userRoleDto);
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult> CreateUser([FromBody] UserRoleDto registerDto)
        {
            // Create a new ApplicationUser object and populate it with data from the UserRoleDto
            var user = new ApplicationUser
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                EmployeeID = registerDto.EmployeeID,
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Designation = registerDto.Designation,
                PhoneNumber = registerDto.PhoneNumber,
            };

            // Attempt to create the user with the provided password
            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (result.Succeeded)
            {
                // Assign the selected role to the new user
                if (!string.IsNullOrEmpty(registerDto.RoleName))
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, registerDto.RoleName);
                    if (!roleResult.Succeeded)
                    {
                        return BadRequest(roleResult.Errors);
                    }
                }

                return Ok();
            }

            return BadRequest(result.Errors);
        }

        [HttpPut("UpdateUser")]
        public async Task<ActionResult> UpdateUser([FromBody] UserRoleDto updateUserDto)
        {
            // Find the existing user by ID
            var user = await _userManager.FindByIdAsync(updateUserDto.UserId);
            if (user == null)
            {
                return NotFound(); 
            }

            // Update the user's properties with the new values from the UserRoleDto
            user.UserName = updateUserDto.UserName;
            user.Email = updateUserDto.Email;
            user.FirstName = updateUserDto.FirstName;
            user.LastName = updateUserDto.LastName;
            user.Designation = updateUserDto.Designation;
            user.PhoneNumber = updateUserDto.PhoneNumber;
            user.EmployeeID = updateUserDto.EmployeeID;

            // Update the user's details
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors); 
            }

            // Change password if a new password is provided
            if (!string.IsNullOrWhiteSpace(updateUserDto.Password))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var passwordResult = await _userManager.ResetPasswordAsync(user, token, updateUserDto.Password);

                if (!passwordResult.Succeeded)
                {
                    return BadRequest(passwordResult.Errors); 
                }
            }

            // Get the user's current roles
            var currentRoles = await _userManager.GetRolesAsync(user);

            // Remove the user from all current roles
            var removeRolesResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
            if (!removeRolesResult.Succeeded)
            {
                return BadRequest(removeRolesResult.Errors);
            }

            // If a new role is provided, assign it to the user
            if (!string.IsNullOrEmpty(updateUserDto.RoleName))
            {
                var roleResult = await _userManager.AddToRoleAsync(user, updateUserDto.RoleName);
                if (!roleResult.Succeeded)
                {
                    return BadRequest(roleResult.Errors); 
                }
            }

            return Ok(); 
        }

        [HttpDelete("DeleteUser/{userId}")]
        public async Task<ActionResult> DeleteUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors);
        }

        // Roles
        [HttpGet("roles")]
        public async Task<ActionResult<IEnumerable<UserRoleDto>>> GetRoles()
        {
            var roles = await _roleManager.Roles
                .Select(role => new UserRoleDto { RoleId = role.Id, RoleName = role.Name })
                .ToListAsync();

            return Ok(roles);
        }


        [HttpPost("AssignRole")]
        public async Task<ActionResult> AssignRole([FromBody] UserRoleDto userRoleDto)
        {
            var user = await _userManager.FindByIdAsync(userRoleDto.UserId);
            if (user == null)
            {
                return NotFound();
            }

            var role = await _roleManager.FindByNameAsync(userRoleDto.RoleName);
            if (role == null)
            {
                return NotFound();
            }

            var result = await _userManager.AddToRoleAsync(user, userRoleDto.RoleName);
            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors);
        }

        [HttpDelete("RemoveRole")]
        public async Task<ActionResult> RemoveRole([FromBody] UserRoleDto userRoleDto)
        {
            var user = await _userManager.FindByIdAsync(userRoleDto.UserId);
            if (user == null)
            {
                return NotFound();
            }

            var role = await _roleManager.FindByNameAsync(userRoleDto.RoleName);
            if (role == null)
            {
                return NotFound();
            }

            var result = await _userManager.RemoveFromRoleAsync(user, userRoleDto.RoleName);
            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors);
        }
    }
}

