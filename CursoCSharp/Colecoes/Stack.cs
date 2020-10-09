using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes{

    class ColecoesStack{
        public static void Executar(){
            var pilha = new Stack();
            pilha.Push(5);
            pilha.Push("et");
            pilha.Push(false);
            pilha.Push(4.56f);
            foreach (var item in pilha){
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nPop: {pilha.Pop()}");
            Console.WriteLine($"Peek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);

        }
    }

}