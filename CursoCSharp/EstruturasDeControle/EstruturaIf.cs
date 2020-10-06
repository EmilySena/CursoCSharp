using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            
            bool par = true;
            string entrada;
            Console.Write("Digite um número: ");
            entrada=Console.ReadLine();
            double.TryParse(entrada, out double number);
            par = number%2==0;
            if(par){
                Console.Write("O número {0} é par",number);
            }
            if(!par){
                Console.WriteLine("O número {0} não é par", number);
            }
            //entrada.ToLower() -> transforma letra maiuscula em minuscula


           
        }
    }
}