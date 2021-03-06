using System.Collections.Generic;

namespace DIO.Series.Interface
{
    public interface IRepo<T> {
        List<T> Lista();
        void Insert(T entity);
        T ReturnById(int id);
        void Update(int id, T entity);
        void Delete(int id);

        int NextId();
    }
}