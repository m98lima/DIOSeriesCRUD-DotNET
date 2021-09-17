namespace DIO.series
{
    public class Serie : EntidadeBase {
        public Genero Genero {get; private set;}
        public string Titulo {get; private set;}
        public string Descricao {get; private set;}
        public int Ano {get; private set;}

        public Serie (int id, Genero genero, string titulo, string descricao, int ano) {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }


        public override string toString () {
            string result = "";
            result += "Gênero: " + this.Genero + Environment.NewLine;
            result += "Título: " + this.Titulo + Environment.NewLine;
            result += "Descrição: " + this.Descricao + Environment.NewLine;
            result += "Ano de lançamento: " + this.Ano + Environment.NewLine;
            return result;
        }
    }
}