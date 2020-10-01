using System;

namespace CursoCSharp.Fundamentos {
    class VarEConst {
        public static void Executar() {
            //araa da circunferencia
            double raio=2.5;
            const double PI = 3.14;
            raio=3.5;
            double area = PI*raio*raio;
        
            Console.WriteLine(area);
            Console.WriteLine("A area é " + area);
            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine ("Está chovendo " + estaChovendo);
            byte idade = 30; //byte só valores pequenos e positivos
            Console.WriteLine ("Idade "+idade);
            sbyte saldoConta = sbyte.MinValue; //mostra menor valor
            Console.WriteLine ("Saldo conta "+ saldoConta);
            short salario = short.MaxValue;
            Console.WriteLine ("Salario "+salario);
            int menorValorInt = int.MinValue;
             Console.WriteLine ("Menor int " + menorValorInt);
            uint Populacao = 300000;
            //inteiro sem sinal
            Console.WriteLine("População = " + Populacao);
            long menorValorLong=long.MinValue;
            Console.WriteLine ("Menor Long "+ menorValorLong);
            ulong populacaoMundial=7_000_000_000;
            Console.WriteLine ("População mundial é "+ populacaoMundial);
            float preco=65.55f; //f ou F no final pra indicar que é float
            Console.WriteLine ("Preco é ", preco);
            decimal distancia = decimal.MaxValue;
            Console.WriteLine ("Distancia "+ distancia);
            char letra = 'e';
            Console.WriteLine ("Letra "+ letra);
            string texto = "Eu sou a Emily!";
            Console.WriteLine (texto);



        }
    }
}
