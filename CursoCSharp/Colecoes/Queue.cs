using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes{
 class ColecoesQueue{
     public static void Executar() {
         var fila = new Queue<string>();
         fila.Enqueue("Amanda");
         fila.Enqueue("Bernardo");
         fila.Enqueue("Clara");
         Console.WriteLine(fila.Peek());
         Console.WriteLine(fila.Count);
         Console.WriteLine(fila.Dequeue());
         Console.WriteLine(fila.Count);
         foreach (var pessoa in fila){
             Console.WriteLine(pessoa);
         }   
        var mix = new Queue();
        mix.Enqueue(5);
        mix.Enqueue("algo");
        mix.Enqueue(false);
        mix.Enqueue(5.78);
        Console.WriteLine(mix.Contains("Algo")); //falso
        Console.WriteLine(mix.Contains("algo"));


    }
 }

}
//fila aceita repetição 