using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes{
    class UsandoDelegate{
        delegate double Soma(double x, double y);
        delegate void ImprimirSoma(double x, double y);
        static double Somar(double a, double b){
            return a+b;
        }
        static void ImprimindoSoma(double a, double b){
            Console.WriteLine(a+b);
        }
        public static void Executar() {
            Soma op1 = Somar;
            Console.WriteLine(op1(5,9));
            ImprimirSoma op2 = ImprimindoSoma;
            op2(7.4,6);
            Func<double,double, double> op3 = Somar;
            Console.WriteLine(op3(6,4,8));
            Action<double,double> op4 = ImprimindoSoma;
            op4(4,5,1);

        }
    }
}