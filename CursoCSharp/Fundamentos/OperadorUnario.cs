using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorUnario {
        public static void Executar() {
            
            var valorNegativo = -1;
            var num1 = 4;
            var num2=5;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);
            num1++;
            Console.WriteLine(num1);
            --num1;
            Console.WriteLine(num1);
            Console.WriteLine(num1++==--num2);
            Console.WriteLine($"{num1} {num2}");
            
           
        }
    }
}
