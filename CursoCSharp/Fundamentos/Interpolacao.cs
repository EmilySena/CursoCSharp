using System;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Emily";
            int idade = 20;
            double altura = 1.60;
            Console.WriteLine("A "+nome+" tem "+idade+" anos de idade"
                +"e tem "+altura+"m de altura");
            //Ou pode fazer assim:
            Console.WriteLine("A {0} tem {1} anos de idade e tem "
                +"{2}m de altura",nome,idade,altura);
            Console.WriteLine($"A {nome} tem {idade} anos de idade e tem "
                +"{altura}m de altura");   
            Console.WriteLine($"1 + 1 = {1+1}!");
            


           
        }
    }
}
