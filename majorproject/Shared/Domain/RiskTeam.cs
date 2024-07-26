using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class RiskTeam : BaseDomainModel, IValidatableObject
    {
        [Required]
        public string? Leader { get; set; }
        [Required]
        public string? Member1 { get; set; }
        [Required]
        public string? Member2 { get; set; }
        public string? Member3 { get; set; }
        public string? Member4 { get; set; }
        public string? Member5 { get; set; }
       

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Collect all members in a list
            var members = new List<string> { Leader, Member1, Member2, Member3, Member4, Member5 };

            // Check for duplicate names
            var duplicateNames = members
                .Where(name => !string.IsNullOrEmpty(name))
                .GroupBy(name => name)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key)
                .ToList();

            if (duplicateNames.Any())
            {
                foreach (var duplicateName in duplicateNames)
                {
                    yield return new ValidationResult(
                        $"The name '{duplicateName}' is duplicated in the team.",
                        new[] { nameof(Leader), nameof(Member1), nameof(Member2), nameof(Member3), nameof(Member4), nameof(Member5) }
                    );
                }
            }
        }
    }
}
