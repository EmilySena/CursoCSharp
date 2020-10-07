using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    public class Cliente{
        public string Nome;
        public readonly Datetime Nascimento;
        public Cliente(string nome, Datetime nascimento){
            Nome = nome;
            Nascimento = nascimento;

           // Nascimento = new Datetime(2010, 10, 10);
        }
        public string GetDataDeNascimento{
            get=> String.Format("{0}/{1}/{2}", Nascimento.Day, 
            Nascimento.Month, Nascimento.Year);
        }


    }
    class Readonly{
        static public void Executar(){
            var novoCliente = new Cliente("Ana Silva",
            new Datetime(1997, 5, 22));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento);
        }
    }



}