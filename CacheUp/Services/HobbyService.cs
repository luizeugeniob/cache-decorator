using CacheUp.Entities;
using CacheUp.Repositories;

namespace CacheUp.Services;

public class HobbyService : IHobbyService
{
    private readonly IRepository<Hobby> _hobbyRepository;

    public HobbyService(IRepository<Hobby> repository)
    {
        _hobbyRepository = repository;
    }

    public IEnumerable<Hobby> GetAll() 
        => _hobbyRepository.GetAll();
}
