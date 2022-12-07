using Microsoft.AspNetCore.Mvc;
using InventorySystem.UseCases.Inventories;
using InventorySystem.CoreBusiness;
namespace InventorySystem.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    private readonly IViewInventoryUseCase _viewInventoryUseCase;


    public WeatherForecastController(ILogger<WeatherForecastController> logger, IViewInventoryUseCase viewInventoryUseCase)
    {
        _logger = logger;
        _viewInventoryUseCase=viewInventoryUseCase;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public Task<List<Inventory>> Get()
    {
        return _viewInventoryUseCase.GetAllInventoryItems();
    }
}
