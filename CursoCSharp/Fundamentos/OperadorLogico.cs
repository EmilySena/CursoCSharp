using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorLogico {
        public static void Executar() {
            
            var fezAlgo = true;
            var fezOutraCoisa = false;
            bool test1 = fezAlgo && fezOutraCoisa;
            Console.WriteLine("Primeiro teste  = {0}", test1);
            bool test2 = fezAlgo||fezOutraCoisa;
            Console.WriteLine("Segundo teste = {0}", test2);
            bool test3 = fezAlgo ^ fezOutraCoisa;
            Console.WriteLine("Terceiro teste  = {0}",test3);
            Console.WriteLine("Quarto teste: {0}", !test3);
           
        }
    }
}
