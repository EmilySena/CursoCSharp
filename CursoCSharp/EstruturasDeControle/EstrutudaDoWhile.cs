using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaDoWhile {
        public static void Executar() {
            string entrada;
            do{
                Console.WriteLine("Digite um numero: ");
                entrada=Console.ReadLine();
                int.TryParse(entrada, out int num);
                Console.WriteLine("{0} + 3 = {1}",num, num+3);
                Console.WriteLine("Deseja continuar? S/N?");
                entrada=Console.ReadLine();

            } while (entrada.ToLower()=="s");
           
        }
    }
}