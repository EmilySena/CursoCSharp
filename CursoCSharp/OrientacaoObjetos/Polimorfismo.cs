using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {
    public class Comida{
        public double Peso;
        public Comida(double peso){
            Peso = peso;
        }
        public Comida(){}
    }
    public class Feijao : Comida{
        public Feijao(double peso) : base(peso) { }
        //public double Peso;
    }
    public class Arroz : Comida{
        //public double Peso;
    }
    public class Salada : Comida{
       // public double Peso;
    }
    public class Pessoa{
        public double Peso;
        /*public void Comer (Feijao feijao){
            Peso += feijao.Peso;
        }
        public void Comer (Arroz arroz){
            Peso += arroz.Peso;
        }
        public void Comer(Salada salada){
            Peso += salada.Peso;
        }*/
        public Comer(Comida comida){
            Peso += comida.Peso;
        }
    }
    class Polimorfismo{
        public static void Executar() {
            Feijao ingrediente1 = new Feijao(0.4);
            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.5;
            Salada ingrediente3 = new Salada();
            ingrediente3.Peso = 0.2;
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Peso = 60.0;
            pessoa1.Comer(ingrediente1);
            pessoa1.Comer(ingrediente2);
            pessoa1.Comer(ingrediente3);
            Console.WriteLine($"Agora o peso da pessoa é {pessoa1.Peso}kg");

        }
    }
}