using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    internal class Usuarios
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }  
        public int Telefone { get; set; }   
        public string Email { get; set; }
        


        public Usuarios(Guid id, string nome, int idade, int telefone, string email)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
            Email = email;
            
        }

        public Usuarios()
        {
        }

        











    }
}
