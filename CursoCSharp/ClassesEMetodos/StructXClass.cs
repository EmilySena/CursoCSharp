using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    public struct PontoA{
        public int X;
        public int Y;
    }
    public class PontoB{
        public int X;
        public int Y;
    }
    class StructXClass{
        public static void Executar(){
            PontoA a = new PontoA{X=4, Y=2};
            PontoA copiaA = a; //atribuição por valor
            a.X = 2;
            Console.WriteLine("Ponto A X:{0}", a.X);
            Console.WriteLine("Cópia A X:{0}", copiaA.X);
            PontoB b = new PontoB {X=5, Y=1};
            PontoB copiaB = b; //atribuiçaõ por referencia
            b.X = 3;
            Console.WriteLine("Ponto B X:{0}", b.X);
            Console.WriteLine("Cópia B X:{0}", copiaB.X);
        
        }
    }

}