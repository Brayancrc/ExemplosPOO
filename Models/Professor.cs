using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    //public sealed class Professor : Pessoa
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }

         //public sealed override void Apresentar()
         public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, sou um professor e meu sálario é {Salario}");
        }
    }
}