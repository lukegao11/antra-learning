using System.Security.Principal;

namespace Week2Assignment4
{
    internal interface IRepository<T> where T : class, IEntity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}