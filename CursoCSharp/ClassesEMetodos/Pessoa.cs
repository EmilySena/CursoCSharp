using System;
using System.Collections.Generic;
using System.Text;
namespace CursoCSharp.ClassesEMetodos{
    class Pessoa{
        public string Nome;
        public int Idade;
        public string Apresentar(){
            return string.Format($"Olá, me chamo {Nome} e tenho {idade} anos.");
        }
        public void ApresentarNoConsole(){
            Console.WriteLine(Apresentar());
        }
        public void Zerar(){
            Nome = "";
            Idade = 0;
        }
    }
}