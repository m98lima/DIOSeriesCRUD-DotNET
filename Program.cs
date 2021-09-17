using System;

namespace DIO.series
{
    class Program {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args) {
            string opcaoUsuario ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X") {
                switch (opcaoUsuario) {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "C":
                        Console.Clea();
                        break;

                    default:
                        Console.WriteLine("Opção inválida, por favor escolha novamente");
                        break;
                }
            }
        }


        private static string ObterOpcaoUsuario() {
            Console.WriteLine();
            Console.WriteLine("DIO séries ao seu dispor");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void ListarSeries() {
            Console.WriteLine("Listar séries:");

            var lista = repositorio.Lista();

            if (lista.Count == 0) {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in lista) {
                Console.WriteLine("#ID {0}: - {1}", serie.Id, serie.Titulo);
            }
        }
    }
}
