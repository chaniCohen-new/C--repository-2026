using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<T> AddItemAsync(T item);
        Task DeleteItemAsync(int id);
        Task UpdateItemAsync(int id, T item);
    }
}