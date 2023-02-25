using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment4
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly List<T> _data;

        public GenericRepository()
        {
            _data = new List<T>();
        }

        public void Add(T item)
        {
            _data.Add(item);
        }

        public void Remove(T item)
        {
            _data.Remove(item);
        }


        public void Save()
        {
            //implement 
        }

        public IEnumerable<T> GetAll()
        {
            return _data;
        }

        public T GetById(int id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }
    }


}
