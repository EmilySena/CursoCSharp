using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {
    public class Carro{
        protected readonly int VelocidadeMaximal;
        int VelocidadeAtual;
        public Carro(int velocidadeMaxima){
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected AlterarVelocidade(int delta){
            int novaVelocidade = VelocidadeAtual + delta;
            if(novaVelocidade < 0){
                VelocidadeAtual = 0;
            } else if(novaVelocidade > VelocidadeMaxima){
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
    
        }
        public virtual int Acelerar(){
            return AlterarVelocidade(5);
        }
        public int Frear(){
            return AlterarVelocidade(-5);
        }
    }
    public class Uno : Carro{
        public Uno() : base(200){}
    }
    public class Ferrari : Carro{
        public Ferrarri() : base(350){}
        public override int Acelerar(){
            return AlterarVelocidade(15);
        }
        //ocultar da classe pai
        public new int Frear(){
            return AlterarVelocidade(-15);
        }

    }


    class Heranca{
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrarri carro2 = new Ferrarri();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine("Ferrari com tipo carro..");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine("Uno com tipo Carro");
            Carro carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());


        }
    }
}