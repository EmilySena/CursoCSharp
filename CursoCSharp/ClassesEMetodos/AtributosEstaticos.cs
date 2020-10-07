using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    class Produto{
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;
        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto(){}
        public double CalcularDesconto(){
            return Preco - Preco * Desconto;
        }


    }
    class AtributosEstaticos{
        public static void Executar(){
           var produto1 = new Produto("Caneta", 3.2, 0.1);
            var produto2 = new Produto(){
                Nome = "Borracha", 
                Preco = 5.3
            
            };
            Produto.Desconto = 0.6;
            Console.Writeline("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.Writeline("Preço com desconto: {0}", produto2.CalcularDesconto());
            Produto.Desconto = 0.04;
             Console.Writeline("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.Writeline("Preço com desconto: {0}", produto2.CalcularDesconto());
        }
    }

}