using Microsoft.AspNetCore.Mvc;
using PexelsProject.Application.Interfaces;

namespace PexelsProject.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhotosController : ControllerBase
    {
        private readonly IPhotoService _photoService;

        public PhotosController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        [HttpGet("{query}")]
        public async Task<IActionResult> Search(string query)
        {
            try
            {
                var result = await _photoService.SearchPhotosAsync(query);
                return Content(result, "application/json");
            }
            catch (Exception ex)
            {
                return Problem(
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError);
            }
        }
    }
}
