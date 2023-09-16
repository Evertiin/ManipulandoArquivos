using Biblioteca.Entidades;
using System;
using System.Dynamic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using Biblioteca.Métodos;

namespace Biblioteca
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Function funcao = new Function();   

            Console.WriteLine("Bem-vindo ao Sistema de Gerenciamento de Biblioteca!");

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Cadastrar usuário");
                Console.WriteLine("2 - Visualizar usuários cadastrados");
                Console.WriteLine("3 - Cadastrar livro");
                Console.WriteLine("4 - Visualizar livros cadastrados");
                Console.WriteLine(" - Sair");

              
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Você escolheu cadastrar um usuário.");
                        funcao.AdicionarOsUsuarios();

                        break;
                    case "2":
                        Console.WriteLine("Você escolheu visualizar usuários cadastrados.");
                        funcao.VisualizarDados();

                        break;
                    case "3":
                        Console.WriteLine("Saindo do programa. Até mais!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;


                }
                
            }

        }
    }
}
































































































