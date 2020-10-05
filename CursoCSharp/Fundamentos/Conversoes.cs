using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            //conversão implicita
            int numero = 34;
            double quebrado = numero;
            Console.WriteLine(quebrado);

            //conversão explicita
            double nota = 9.6;
            int notaArredondada = (int) nota;
            Console.WriteLine("Nota arredondada: {0}", notaArredondada);

            Console.Write("Idade: ");
            string idade = Console.ReadLine();
            int idadeInt = int.Parse(idade);
            Console.WriteLine("Sua idade é {0}", idadeInt);

            idadeInt = Convert.ToInt32(idade);
            Console.WriteLine("Resultado: {0}", idadeInt);

            Console.Write("Primeiro número: ");
            string palavra=Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1 : {0}", numero1);

            Console.Write("Segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
    


           
        }
    }
}
