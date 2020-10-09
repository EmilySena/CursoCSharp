using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes{
 class ColecoesSet{
     public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);
            var combo = new HashSet<Produto> { 
                new Produto("Blusa", 25.5),
                new Produto("Calça", 30.0),
                new Produto("Quadro", 10.9)
            };
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            
            foreach (var item in carrinho){
               
                Console.WriteLine($" {item.Nome} {item.Preco}");

            }
            Console.WriteLine(carirnho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carirnho.Count);


        }
 }

}
//não aceita repetição
//naõ tem index