using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepository<T>
    {
         List<T> FindAll();
         T FindById(int id);
         void Save(T entity);
         void Delete(int id);
         void Update(int id, T entity);
         int NextId();
    }
}