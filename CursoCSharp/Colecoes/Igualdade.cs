using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes{
    public class Produto{
        public string Nome;
        public double Preco;
        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;

        }
        public override bool Equals(object obj){
            Produto outro = (Produto)obj;
            bool mesmoNome = Nome == outro.Nome;
            bool mesmoPreco = Preco == outro.Preco;
            return mesmoNome && mesmoPreco;
        }
        public override int GetHashCode(){
            return Nome.Length;
        }

    }
 class Igualdade{
     public static void Executar() {
            var p1 = new Produto("Lápis", 0.5);
            var p2 = new Produto("Lápis", 0.5);
            var p3 = p2;
            Console.WriteLine(p1==p2);
            Console.WriteLine(p2==p3);
            Console.WriteLine(p1.Equals(p2));


     }
 }

}