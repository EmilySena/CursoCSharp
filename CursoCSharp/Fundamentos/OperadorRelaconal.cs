using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorRelacional {
        public static void Executar() {
            Console.Write("Digite um número entre 0 e 10: ");
            double.TryParse(Console.ReadLine(), out double numero);
            Console.WriteLine("Numero invalido? {0}", numero>10);
            Console.WriteLine("Número invalido? {0}", numero<0);
            Console.WriteLine("O numero é 10? {0}", numero ==10);
            Console.WriteLine("O numero é maior que 6? {0}",numero>=6);
            Console.WriteLine("O numero é menor que 6? {0}", numero<6);
            Console.WriteLine("O numero é menor ou igual a 3? {0}", numero <=3);





           
        }
    }
}
