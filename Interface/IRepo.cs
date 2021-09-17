using System.Collections.Generic;

namespace DIO.series
{
    public interface IRepo<T> {
        List<T> Lista();
        void insert(T entity);
        T returnById(int id);
        void update(int id, T entity);
        void delete(int id);

        int nextId();
    }
}