using System;
using System.Collections.Generic;
using DIO.Series.Interface;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepo<Serie> {
        private List<Serie> listaSerie = new List<Serie>();
        
        public List<Serie> Lista() {
            return listaSerie;
        }
        
        public void Insert(Serie entity) {
            listaSerie.Add(entity);
        }
        
        public Serie ReturnById(int id) {
            return listaSerie[id];
        }
        
        public void Update(int id, Serie entity) {
            listaSerie[id] = entity;
        }

        public void Delete(int id) {
            listaSerie[id].Excluir();
        }

        public int NextId() {
            return listaSerie.Count;
        }
    }
}