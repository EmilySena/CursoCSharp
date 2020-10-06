using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElse {
        public static void Executar() {
            Console.Write("Digite algo um número de 0 a 5: ");
            int.TryParse(Console.ReadLine(), out int numero);
            switch (numero){
                case 0:
                    Console.WriteLine("Você pensa muito pequeno");
                    break;
                case 1:
                    Console.WriteLine("É alguma coisa pelo menos");
                    break;
                case 2:
                    Console.WriteLine("Você vai encontrar seu par");
                    break;
                case 3:
                    Console.WriteLine("Vai ser um trio!");
                    break;
                case 4:
                    Console.WriteLine("Parabéns! Você faz parte do quarteto fantástico agora!!!");
                    break;
                case 5:
                    Console.WriteLine("Bom, você é o máximo mesmo!!!");
                    break;
                default:
                    Console.WriteLine("Número inválido");
            }
            

           
        }
    }
}