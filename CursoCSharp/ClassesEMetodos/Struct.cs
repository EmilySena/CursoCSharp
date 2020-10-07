using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{

    interface Ponto{
        void MoverNaDiagonal(int Delta);
    }
    struct Coordenada: Ponto{
        public int X;
        public int Y;
        public Coordenada(int x, int y){
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta){
            x += delta;
            y += delta;
        
        }


    }

    class ExemploStruct{
        public static void Executar(){
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 4;
            coordenadaInicial.Y = 3;
            Console.WriteLine("Coordenada inicial é: ");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);
            var coordenadaFinal = new Coordenada(x:6, y:8);
            coordenadaFinal.MoverNaDiagonal(10);
            Console.WriteLine("Coordenada final é: ");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}