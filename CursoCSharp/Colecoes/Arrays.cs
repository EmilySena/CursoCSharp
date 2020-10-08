using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes{
    class Array{
        public static void Executar() {
            string[] aluno = new string[4];
            aluno[0] = "Manuela";
            aluno[1] = "Bruno";
            aluno[2] = "Rafael";
            aluno[3] = "Gabi";
            foreach (var pessoa in aluno){
                Console.WriteLine(pessoa);
            }
            double soma = 0;
            double[] notas = {9.3, 5.7, 8.7, 6.5};
            foreach (var nota in notas){
                soma += nota;
            }
            double media = soma/notas.Length;
            Console.WriteLine(media);

            char[] letras =  {'C', 'a', 'l', 'o', 'r'};
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }

}