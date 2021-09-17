using Sysyem;
using namespace DIO.series.Interface;

namespace DIO.series.Classes
{
    public class SerieRepositorio : IRepo<Serie> {
        private List<Serie> listaSerie = new List<Serie>();
        
        List<T> Lista() {
            return listaSerie;
        }
        
        void Insert(T entity) {
            listaSerie[id].Add(entity);
        }
        
        T ReturnById(int id) {
            return listaSerie[id];
        }
        
        void Update(int id, T entity) {
            listaSerie[id] = entity;
        }

        void Delete(int id) {
            listaSerie[id].Excluir();
        }

        int NextId() {
            return listaSerie.Count;
        }
    }
}