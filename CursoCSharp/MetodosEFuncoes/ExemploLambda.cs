using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes{
    class ExemploLambda{
        public static void Executar(){
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda no C#");
            };
            algoNoConsole();
            Func<int> jogarDado = () =>{
                Random random = new Random();
                return random.Next(1,7);
            };
            Console.WriteLine(jogarDado());
            Func<int,string> conversorHex = num => num.ToString("X");
            Console.WriteLine(conversorHex(9238));
            Func<int, int, int, string> formatarData = (dia,mes,ano)=>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(6,4,2000));
        }
    }




}