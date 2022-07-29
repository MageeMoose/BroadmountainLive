using BroadmountainLive.Server.Data;
using BroadmountainLive.Shared;
using Microsoft.EntityFrameworkCore;

namespace BroadmountainLive.Server.Services.NavImageService
{
    public class NavImageService :INavImageService
    {
        private readonly DataContext _context;

        public NavImageService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<NavImage>>> GetNavImages()
        {
            var response = new ServiceResponse<List<NavImage>>
            {
                Data = await _context.NavImages.ToListAsync()
            };

            return response;
        }
    }
}
