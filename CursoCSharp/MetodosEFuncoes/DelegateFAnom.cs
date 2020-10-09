using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes{
    class DelegateFAnom{
        delegate string StringOperacao(string s);
        public static void Executar() {
            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };
            Console.WriteLine(inverter("É a vida, não é mesmo?"));
        }
    }
}