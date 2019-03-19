using System.Collections.Generic;

namespace ConsoleApp1.Repos
{
    public abstract class CarServiceRepository<T,K>
    {
        //private Model1Container _context;

        protected CarServiceRepository()
        {
        }

        public abstract void Add(T entity);
        public abstract T Get(K id);
        public abstract ICollection<T> GetAll();
        public abstract void Insert(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
    }
}