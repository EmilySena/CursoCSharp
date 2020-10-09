using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes{
    public class ExtensoesInteiro{
        public static int Soma(this int a, int b){
            return a + b;
        }
        public static int Subtracao(this int a, int b){
            return a - b;
        }
    }
    class MetodosExtensao{
        public static void Executar() {
            int num = 8;
            Console.WriteLine(num.Soma(7));
            Console.WriteLine(num.Subtracao(5));
            Console.WriteLine(3.Soma(2));
            Console.WriteLine(6.Subtracao(4));
        }
    }
}