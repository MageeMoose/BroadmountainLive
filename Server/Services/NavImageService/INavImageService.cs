using BroadmountainLive.Shared;

namespace BroadmountainLive.Server.Services.NavImageService
{
    public interface INavImageService
    {
        Task<ServiceResponse<List<NavImage>>> GetNavImages();

    }
}
