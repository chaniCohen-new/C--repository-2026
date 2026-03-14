using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public List<T> GetAll();
        public T Get(int id);
        public T AddItem(T item);
        public void DeleteItem(int id);
        public void UpdateItem(int id, T item);
    }
}