﻿using System;
using DIO.Series.Enums;
using DIO.Series.Interface;
using DIO.Series.Classes;


namespace DIO.Series
{
    class Program {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args) {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X") {
                switch (opcaoUsuario) {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opção inválida, por favor escolha novamente");
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }


        private static string ObterOpcaoUsuario() {
            Console.WriteLine();
            Console.WriteLine("DIO séries ao seu dispor");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
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

        private static void InserirSerie() {
            Console.WriteLine("Inserir nova série");
            
            Console.WriteLine("Selecione o gênero entre as opções abaixo: ");
            foreach (int i in Enum.GetValues(typeof(Genero))) {
                Console.WriteLine("{0}: {1}", i, Enum.GetName(typeof(Genero), i));
            }
            
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(repositorio.NextId(), 
                                        (Genero)entradaGenero, 
                                        entradaTitulo, 
                                        entradaDescricao, 
                                        entradaAno);
            
            repositorio.Insert(novaSerie);
        }
    }
}
