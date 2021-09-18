using System;
using DIO.Series.Enums;

namespace DIO.Series.Classes
{
    public class Serie : EntidadeBase {
        public Genero Genero {get; private set;}
        public string Titulo {get; private set;}
        public string Descricao {get; private set;}
        public int Ano {get; private set;}
        private bool Excluido {get; set;}

        public Serie (int id, Genero genero, string titulo, string descricao, int ano) {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }


        public override string ToString () {
            string result = "";
            result += "Gênero: " + this.Genero + Environment.NewLine;
            result += "Título: " + this.Titulo + Environment.NewLine;
            result += "Descrição: " + this.Descricao + Environment.NewLine;
            result += "Ano de lançamento: " + this.Ano + Environment.NewLine;
            return result;
        }

        public void Excluir() { 
            this.Excluido = true;
        }
    }
}