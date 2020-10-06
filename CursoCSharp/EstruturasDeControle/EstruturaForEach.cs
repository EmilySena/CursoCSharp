using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaForEach {
        public static void Executar() {
           string entrada;
           Console.WriteLine("Digite seu nome: ");
           entrada = Console.ReadLine();
           foreach (var letra in entrada){
               Console.Write("{0} ", letra);
           }
        }
    }
}