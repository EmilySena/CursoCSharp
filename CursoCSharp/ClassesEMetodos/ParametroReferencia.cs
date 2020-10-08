using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    class ParametroReferencia{
        public static void AlterarRef(ref int numero){
            numero = numero + 300;
        }
        public static void AlterarOut(out int num1, out int num2){
            num1 = 0;
            num2 = 0;
            num1 += 35;
            num2 += 25;
        }
        public static void Executar(){
            int num = 6;
            AlterarRef(ref num);
            Console.WriteLine(num);
            AlterarOut(out int x, out int y);
            Console.WriteLine($"{x} {y}");
        }
    }


}