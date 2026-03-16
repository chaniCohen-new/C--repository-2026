using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
         List<T> GetAll();
         T Get(int id);
         T AddItem(T item);
         void DeleteItem(int id);
         void UpdateItem(int id, T item);
    }
}