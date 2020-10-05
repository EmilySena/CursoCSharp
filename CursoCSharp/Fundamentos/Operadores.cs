using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Operadores {
        public static void Executar() {
            var preco = 2000.0;
            var imposto = 200;
            var desconto = 0.15;

            double total = preco+imposto;
            var totalComDesconto = total - (total*desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //IMC
            double peso = 60.0;
            double altura = 1.6;
            double imc = peso / Math.Pow(altura,2);
            Console.WriteLine($"IMC é {imc}.");

            //resto
            int par = 48;
            int impar = 65;
            Console.WriteLine("{0}/2 tem resto {1}", par, par%2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar%2);

   


           
        }
    }
}
