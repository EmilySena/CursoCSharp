using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes{
    class DelegateParametro{
        public delegate int Operacao(int x, int y);
        public static int Soma(int x, int y){
            return x+y;
        }
        public static string Calculadora(Operacao op, int x, int y){
            var resultado = op(x,y);
            return "Resultado: "+ resultado;
        }
        public static void Executar() {
            Operacao subtracao = (x,y) => x-y;
            Console.WriteLine(Calculadora(subtracao,7,1));
            Console.WriteLine(Calculadora(Soma,9,5));


        }
    }
}