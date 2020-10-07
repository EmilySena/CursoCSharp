using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    class CalculadoraEstatica{
        //Metodo de classe ou metodo estatico
        public static int Somar(int a, int b){
            return a + b;
        }
        //metodo de instancia
        public int Subtrair(int a, int b){
            return a - b;
        }

    }
    class MetodosEstaticos{
        public static void Executar(){
            var resultado = CalculadoraEstatica.Somar(4,8);
            Console.WriteLine(resultado);
            
            var calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Subtrair(3,9));
        }
    }
}

