using System.Net.Http.Json;
using BroadmountainLive.Shared;

namespace BroadmountainLive.Client.Services.NavImageService;

public class NavImageService : INavImageService
{
    private readonly HttpClient _http;

    public NavImageService(HttpClient http)
    {
        _http = http;
    }


    public List<NavImage> NavImages { get; set; } = new List<NavImage>();
    public async Task GetNavigationImages()
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<NavImage>>>("api/navImage");
       if (result != null && result.Data != null)
           NavImages = result.Data;
    }
}