using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {
    interface OperacaoBinaria{
        int Operacao(int a, int b);
    }
    class Soma : OperacaoBinaria{
        public int Operacao(int a, int b) { 
            return a + b; 
        }
    }
    class Subtracao : Operacao{
        public int Operacao(int a, int b, int c) {
            return a - b;
        }
    }
    class Multiplicacao : Operacao{
        public int Operacao(int a, int b){
            return a*b;
        }
    }
    class Divisao : Operacao{
        public int Operacao(int a, int b){
            return a/b;
        }
    }
    class Calculadora{
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>{
            new Soma(),
            new Subtracao(), 
            new Multiplicacao(), 
            new Divisao()
        };
        public string ExecutarOperacoes(int a, int b){
            string resultado = "";
            foreach(var op in operacoes){
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a,b)}\n";
            }
            return resultado;
        }
    }
    class Interface{
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(78,5);
            Console.Writeline(resultado);
        }
    }

}