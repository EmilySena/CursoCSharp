using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class UsandoBreak {
        public static void Executar() {
           Random random = new Random();
           int numero = random.Next(1,100);
           Console.WriteLine("O número é {0}",numero);
           int soma=0;
           for(int i=1; i<=numero; i++) {
               soma++;
               if(i==numero){
                   Console.Write("O número foi encontrado depois de {0} repetições",soma);
                    break;
               }
           }
           
        }
    }
}