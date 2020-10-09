using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes{
    delegate double Operacao(double x, double y);
    class LambdaDelegate{
        public static void Executar() {
            Operacao soma = (x,y) => x + y;
            Operacao subtracao = (x,y) => x - y;
            Operacao multiplicacao = (x,y) => x*y;
            Console.WriteLine(soma(5,9));
            Console.WriteLine(subtracao(36,26));
            Console.WriteLine(multicacao(7,9));
        }
    }
}