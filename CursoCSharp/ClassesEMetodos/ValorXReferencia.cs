using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    public class Dependente{
        public string Nome;
        public int Idade;
    }
    class ValorXReferencia{

        public static void Executar(){
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copianumero}");
            numero++;
            Console.WriteLine($"{numero} {copianumero}");
            Dependente dep = new dependente { 
                Nome = "Alfredo",
                Idade = 30
            };
            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Bianca";
            copiaDep.Idade = 23;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }



}