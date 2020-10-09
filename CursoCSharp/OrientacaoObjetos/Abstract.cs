using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {
    public abstract class Celular{
        public abstract string Assistente();
        public string Tocar(){
            return "Trim trim trim...";
        }
    }
    public class Iphone : Celular{
        public override string Assistente() { 
            return "Olá, eu sou a Siri!";
        }
    }
    public class Samsung : Celular{
        public override string Assistente() { 
            return "Olá, eu sou a Google Assistente!";
        }

    }
    class Abstract{
        public static void Executar(){
            var celulares = new List<Celular>{
                new Iphone(), 
                new Samsung()           
            };
            foreach (var item in celulares){
                Console.WriteLine(item.Assistente());
            }
        }
    }

}