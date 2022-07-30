using BroadmountainLive.Shared;

namespace BroadmountainLive.Client.Services.NavImageService;

public class NavImageService : INavImageService
{
    private readonly HttpClient _http;

    public NavImageService(HttpClient http)
    {
        _http = http;
    }


    public List<NavImage> NavImages { get; set; }
    public Task GetNavigationImages()
    {
        throw new NotImplementedException();
    }
}