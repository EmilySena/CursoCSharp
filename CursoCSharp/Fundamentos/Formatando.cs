using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class Formatando {
        public static void Executar() {
            
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //arredonda pra uma casa decimal
            Console.WriteLine(valor.ToString("C")); //mostra como valor monetário
            Console.WriteLine(valor.ToString("P")); //valor percentual e multiplica por 100
            Console.WriteLine(valor.ToString("#.##")); //numero com a formatação q vc quer, duas casas decimais
            CultureInfo culture = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0",culture));
            int inteiro =256;
            Console.WriteLine(valor.ToString("D10"));
            

           
        }
    }
}
