using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class UsandoContinue {
        public static void Executar() {
           int intervalo=100;
           Console.WriteLine("Números ímpares entre 0 e {0}",intervalo);
           int soma=0;
           for(int i=0; i<=intervalo; i++) {
               soma++;
               if(i%2==0){
                   continue;
               }
               Console.WriteLine(i+" ");
           }
           Console.WriteLine("Há {0} números ímpares", soma);
           
        }
    }
}