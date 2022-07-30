using Microsoft.AspNetCore.Mvc;

namespace BroadmountainLive.Server.Controllers
{
    public class NavImageController : ControllerBase
    {
        private readonly INavImageService _navImageService;

        public NavImageController(INavImageService navImageService)
        {
            _navImageService = navImageService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<NavImage>>>> GetNavigationImages()
        {
            var result = await _navImageService.GetNavImages();
            return Ok(result);
        }

    }
}
