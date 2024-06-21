namespace CacheUp.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
