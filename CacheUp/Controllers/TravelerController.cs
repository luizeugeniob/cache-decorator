using CacheUp.Entities;
using CacheUp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CacheUp.Controllers;

[ApiController]
[Route("[controller]")]
public class TravelerController : ControllerBase
{
    private readonly ITravelerService _travelerService;

    public TravelerController(ITravelerService weatherForecastService)
    {
        _travelerService = weatherForecastService;
    }

    [HttpGet]
    public IEnumerable<Traveler> GetAll()
    {
        return _travelerService.GetAll();
    }
}
