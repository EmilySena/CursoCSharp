using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{

    public enum Genero { Acao, Terror, Aventura, Romance, Comedia, Desenho};
    public class Serie{
        public string Título;
        public Genero GeneroDaSerie;
        public int episodio;
        public int temporada;
    }
    class ExemploEnum{
        public static void Executar(){
            int identificador = (int)Genero.Animacao;
            Console.WriteLine(identificador);

            var serieNova = new Serie();
            serieNova.Titulo = "The Walking Dead";
            serieNova.Genero = Genero.Terror;
            serieNova.episodio = 5;
            serieNova.temporada = 8;
            Console.WriteLine("Vamos assistir {0}, é uma serie de {1}", serieNova.Titulo, serieNova.Genero);
            Console.WriteLine("Epsisodio {0} da temporada {1}", serieNova.episodio,
                serieNova.temporada);
        }
    }


}