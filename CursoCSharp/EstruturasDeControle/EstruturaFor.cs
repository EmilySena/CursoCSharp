using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
           string entrada;
           Console.WriteLine("Digite um número: ");
           entrada = Console.ReadLine();
           int.TryParse(entrada, out int numero);
           int pares=0;
           for(int i=1; i<numero; i++){
               if(i%2==0){
                   pares++;
               }
           }
           Console.WriteLine("Entre 0 e {0}, há {1} números pares",
                numero, pares);
           
        }
    }
}