using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual é sua idades? ");
            int idade = int.Parse(Console.Readline());
            Console.Write("Qual é o seu salário? ");
            double salário = double.Parse(Console.Readline(),CultureInfo.InvariantCulture);
        
            Console.WriteLine($"{nome} {idade} R${salario}");
            
        }
    }
}
