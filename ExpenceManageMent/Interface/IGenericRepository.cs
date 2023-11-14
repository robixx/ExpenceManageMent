namespace ExpenceManageMent.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllListAsync();
        Task<List<T>> GetAsync(int id);
        Task<string> AddEntityAsync(T entity);
        Task<bool> UpdateEntity(T entity);
        Task<bool> DeleteEntity(int id);
    }
}
