using CacheUp.Entities;

namespace CacheUp.Services;

public interface IHobbyService
{
    IEnumerable<Hobby> GetAll();
}
