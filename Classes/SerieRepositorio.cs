using Sysyem;
using namespace DIO.series.Interface;

namespace DIO.series.Classes
{
    public class SerieRepositorio : IRepo<Serie> {
        private List<Serie> listaSerie = new List<Serie>();
        
        List<T> Lista() {
            //Mostrar elementos da lista
        }
        
        void insert(T entity) {
            //Inserir novo elemento na lista
        }
        
        T returnById(int id) {
            //Procurar elemento na lista pelo id
        }
        
        void update(int id, T entity) {
            //Substituir um elemento na lista
        }

        void delete(int id) {
            //Deletar elemento da lista
        }

        int nextId() {
            //Retorna próximo id
        }
    }
}