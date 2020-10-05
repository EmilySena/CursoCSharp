using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElse {
        public static void Executar() {
            
            bool par = true;
            string entrada;
            Console.Write("Digite um número: ");
            entrada=Console.ReadLine();
            Double.TryParse(entrada, out double number);
            par = number%2==0;
            if(par){
                Console.Write("O número {0} é par",number);
            }
            else{
                Console.WriteLine("O número {0} não é par", number);
            }
            

           
        }
    }
}