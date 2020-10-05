using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorAtribuicao {
        public static void Executar() {
            var num1 = 5;
            num1 = 7;
            num1 += 10; //num1=num1+10
            num -=8;
            num1 *= 5;
            num1 /= 9;
            Console.WriteLine(num1);
            int a=3;
            int b=a;
            a++;
            b--;
            Console.WriteLine("O valor de a é {0}, e o valor de b é {1}", a, b);
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome ="joao";
            dynamic d = c;
            d.nome = "Maria";
            Console.WriteLine(c.nome);




           
        }
    }
}
