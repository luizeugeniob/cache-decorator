using CacheUp.Entities;

namespace CacheUp.Services;

public interface ITravelerService
{
    IEnumerable<Traveler> GetAll();
}
