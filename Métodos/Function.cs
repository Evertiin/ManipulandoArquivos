using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca.Entidades;

namespace Biblioteca.Métodos
{
    internal class Function
    {
       

 
        public void AdicionarOsUsuarios()
        {
            List<Usuarios> listaDeUsuarios = new List<Usuarios>();
            Usuarios usuario = new Usuarios();
            

            bool adicionarUsuarios = true;
            string caminhoDoArquivo = Path.Combine(@"C:\\CSharp\Test.txt");



            while (adicionarUsuarios)
            {                
                Console.WriteLine("Digite o nome do Usuário:");
                
                string? nome = Console.ReadLine();
                bool encontrada = VerificarStringEmArquivo(nome, caminhoDoArquivo);



                while (encontrada)
                    {
                        Console.WriteLine($"O usuário'{nome}' já existe");

                        Console.WriteLine("Digite o nome do Usuário:");
                        nome = Console.ReadLine();
                    break;

                    }

                


                listaDeUsuarios.Add(usuario);

                    SalvarUsuariosEmArquivo(listaDeUsuarios);

                    Console.WriteLine("Usuário cadastrado com sucesso");

                

                while (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Entre com seu usuário válido:");
                    nome = Console.ReadLine();



                }

                Console.ReadKey();

                Console.WriteLine("Deseja adiconar mais usuários?:");
                
                string? resposta = Console.ReadLine();


                if (resposta?.ToLower() != "s")
                {
                    adicionarUsuarios = false;
                    Console.Clear();

                }


            }

        }



        public void SalvarUsuariosEmArquivo(List<Usuarios> listaUsuarios)
        {


            string diretorioDoApp = AppDomain.CurrentDomain.BaseDirectory;

            string caminhoDoArquivo = Path.Combine(diretorioDoApp, @"C:\\CSharp\Test.txt");

            using (StreamWriter writer = new StreamWriter(caminhoDoArquivo, true))
            {
                foreach (var usuario in listaUsuarios)
                {

                    writer.WriteLine(listaUsuarios);
                }
            }

            
        }
        
        public void VisualizarDados()
        {

            string ReaderUsuários = File.ReadAllText(@"C:\\CSharp\Test.txt");
            
        }

        static bool VerificarStringEmArquivo(string stringParaVerificar, string nomeArquivo)
        {
            string diretorioDoApp = AppDomain.CurrentDomain.BaseDirectory;

            string caminhoDoArquivo = Path.Combine(diretorioDoApp, @"C:\\CSharp\Test.txt");

            try
            {
                
                string conteudoArquivo = File.ReadAllText(caminhoDoArquivo);

               
                return conteudoArquivo.Contains(stringParaVerificar);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"O usuário '{caminhoDoArquivo}' já existe.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ocorreu um erro: {e.Message}");
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex);
            }

            return false;
        }
    }
}
             


            


            

















        
    

