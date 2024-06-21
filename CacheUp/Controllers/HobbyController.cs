using CacheUp.Entities;
using CacheUp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CacheUp.Controllers;

[ApiController]
[Route("[controller]")]
public class HobbyController : ControllerBase
{
    private readonly IHobbyService _hobbyService;

    public HobbyController(IHobbyService hobbyService)
    {
        _hobbyService = hobbyService;
    }

    [HttpGet]
    public IEnumerable<Hobby> GetAll()
    {
        return _hobbyService.GetAll();
    }
}
