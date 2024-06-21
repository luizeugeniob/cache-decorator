using CacheUp.Entities;

namespace CacheUp.Repositories;

public class TravelerRepository : IRepository<Traveler>
{
    private static readonly string[] BankPower = [ "Alexandra", "Ana", "Anka", "Lia", "Luiz", "Tiago", "Satrio", "Vignesh" ];

    public IEnumerable<Traveler> GetAll()
    {
        return Enumerable.Range(1, 5).Select(index => new Traveler
        {
            Name = BankPower[Random.Shared.Next(BankPower.Length)]
        })
        .ToArray();
    }
}
