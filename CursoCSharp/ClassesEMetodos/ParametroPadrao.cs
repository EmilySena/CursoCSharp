using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    class ParametroPadrao{
        public static int Soma(int a = 4, int b = 5){
            return a + b;
        }
        public static void Executar(){
            Console.WriteLine(Somar(2,6));
            Console.WriteLine(Somar(8));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b:9));
        }
    }


}