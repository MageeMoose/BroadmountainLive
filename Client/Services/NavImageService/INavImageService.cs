using BroadmountainLive.Shared;

namespace BroadmountainLive.Client.Services.NavImageService;

public interface INavImageService
{
    List<NavImage> NavImages { get; set; }
    Task GetNavigationImages();

}