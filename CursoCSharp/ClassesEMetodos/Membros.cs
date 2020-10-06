using System;
using System.Collections.Generic;
using System.Text;
namespace CursoCSharp.ClassesEMetodos{
    class Membros{
        public static void Executar() {
            Pessoa Fulano = new Pessoa();
            Fulano.Nome = "Fernanda";
            Fulano.Idade = 21;

            Console.WriteLine($"{Fulano.Nome} tem {Fulano.Idade} anos");
            Fulano.ApresentarNoConsole();
            Fulano.Zerar();
            var  Creide = new Pessoa();
            Creide.Nome = "Cleiton";
            Creide.Idade = 56;
            var apresentacaoDoCreide = Creide.Apresentar();

        }
    }
}