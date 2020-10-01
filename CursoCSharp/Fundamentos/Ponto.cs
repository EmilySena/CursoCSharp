using System;

namespace CursoCSharp.Fundamentos {
    class Ponto {
        public static void Executar() {
            var saudacao= "olá".ToUpper().Insert(3," World!")
                .Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);
            Console.WriteLine("Testanto...".Length);
            string valorImportante=null;
            //não usar . para vazio
            Console.WriteLine(valorImportante?.Length);
            //? verifica primeiro se pode, deixa o código mais seguro
            
        }
    }
}
