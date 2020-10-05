using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            
            bool par = true;
            string entrada;
            Console.Write("Digite um número: ");
            entrada=Console.ReadLine();
            Double.TryParse(entrada, out double number);
            par = number%2==0;
            bool divisivelPor3 = number%3==0;
            bool divisivelPor5 = number%5==0;
            bool divisivelPor7 = number%7==0;
            bool divisivelPor11 = number%11==0;
            if(par){
                Console.Write("O número {0} é par",number);
            }
            else{
                Console.WriteLine("O número {0} não é ímpar", number);
                if(divisivelPor3){
                    Console.WriteLine("O número {0} é divisivel por 3", number);
                }
                else if(divisivelPor5){
                    Console.WriteLine("O número {0} é divisivel por 5", number);
                }
                else if(divisivelPor7){
                    Console.WriteLine("O número {0} é divisivel por 7", number);
                }
                else if(divisivelPor9){
                    Console.WriteLine("O número {0} é divisivel por 11", number);
                }
                else{
                    Console.WriteLine("O número {0} não é divisivel por 3, 5, 7 ou 11",number);
                }
            
            }
            


           
        }
    }
}