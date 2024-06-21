using CacheUp.Entities;

namespace CacheUp.Repositories;

public class HobbyRepository : IRepository<Hobby>
{
    private static readonly string[] Hobbies = ["Run", "Sleep", "Read", "Travel", "Listen music", "Play tennis", "Photography", "Learn languages"];

    public IEnumerable<Hobby> GetAll()
    {
        return Enumerable.Range(1, 5).Select(index => new Hobby
        {
            Name = Hobbies[Random.Shared.Next(Hobbies.Length)]
        })
        .ToArray();
    }
}
