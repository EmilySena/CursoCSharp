using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    class ParametrosNomeados{
        public static void Formatar(int dia, int mes, int ano){
            Console.Write("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar(){
            Formatar(mes: 6, dia:13, ano: 2020);

        }
    }
}