using CacheUp.Entities;
using CacheUp.Repositories;

namespace CacheUp.Services;

public class TravelerService : ITravelerService
{
    private readonly IRepository<Traveler> _travelerRepository;

    public TravelerService(IRepository<Traveler> weatherForecastsRepository)
    {
        _travelerRepository = weatherForecastsRepository;
    }

    public IEnumerable<Traveler> GetAll() 
        => _travelerRepository.GetAll();
}
