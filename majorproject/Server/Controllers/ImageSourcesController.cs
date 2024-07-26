using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using majorproject.Server.Data;
using majorproject.Shared.Domain;
using majorproject.Server.IRepository;
using majorproject.Server.gemini;
using System.Diagnostics;
namespace majorproject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageSourcesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ImageSourcesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/ImageSources
        [HttpGet]
        public async Task<IActionResult> GetImageSources()
        {
            var imageSources = await _unitOfWork.ImageSources.GetAll();
            return Ok(imageSources);
        }

        // GET: api/ImageSources/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetImageSource(int id)
        {
            var imageSource = await _unitOfWork.ImageSources.Get(q => q.Id == id);

            if (imageSource == null)
            {
                return NotFound();
            }

            return Ok(imageSource);
        }

        // PUT: api/ImageSources/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImageSource(int id, ImageSource imageSource)
        {
            if (id != imageSource.Id)
            {
                return BadRequest();
            }
            Debug.WriteLine("hello world 1");
            var ai = new GemAI();
            await ai.RiskTableGeneration(imageSource);
            Debug.WriteLine("hello world 4");
            _unitOfWork.ImageSources.Update(imageSource);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ImageSourceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
                
            }
           
            return NoContent();
            
        }

        // POST: api/ImageSources
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ImageSource>> PostImageSource(ImageSource imageSource)
        {
            await _unitOfWork.ImageSources.Insert(imageSource);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetImageSource", new { id = imageSource.Id }, imageSource);
        }

        // DELETE: api/ImageSources/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImageSource(int id)
        {

            var imageSource = await _unitOfWork.ImageSources.Get(q => q.Id == id);
            if (imageSource == null)
            {
                return NotFound();
            }

            await _unitOfWork.ImageSources.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ImageSourceExists(int id)
        {
            var imageSource = await _unitOfWork.ImageSources.Get(q => q.Id == id);
            return imageSource != null;
        }
    }
}
