using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes{
    
 class ColecoesDictionary{
     public static void Executar() {
            var series = new Dictionary<int,string>();
            series.Add(2000,"Game Of Thrones");
            series.Add(2001,"Breaking Bad");
            series.Add(2007,"The Walking Dead");
            series.Add(2009,"Orange is the new black");
            if (series.ContainsKey(2001)){
                Console.WriteLine("2001: " + series[2001]);
                Console.WriteLine("2001: " + series.GetValueOrDefault(2001));
            }
            Console.WriteLine(series.ContainsValue("Friends"));
            Console.WriteLine($"Removeu? {series.Remove(2001)}");
            series.TryGetValue(2017, out string serie2017);
            Console.WriteLine(serie2017);
            foreach(var chave in series.Keys){
                Console.WriteLine(chave);
            }
            foreach(var item in series.Values){
                Console.WriteLine(item);
            }
            foreach(KeyValuePair<int,string> serie in series){
                Console.WriteLine($"{serie.Value} é de {serie.Key}");
            }
            foreach(var serie in series){
                Console.WriteLine($"{serie.Value} é de {serie.Key}");
            }


     }
 }

}