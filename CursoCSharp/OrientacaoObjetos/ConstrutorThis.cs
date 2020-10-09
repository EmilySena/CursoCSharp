using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {
    public class Animal{
        public string Nome { get; set; }
        public Animal(string nome){
            Nome = nome;
        }
    }
    public class Gato : Animal {
        public double Altura{ get; set; }
        public Gato(string nome) : base(nome){
            Nome = nome;
        }
        public Gato(string nome, double altura) : this(nome){
            Altura = altura;
        }
        public override string ToString(){
            return $"{Nome} tem {Altura}cm de altura!";
        }
        public void Miau(){
            Console.WriteLine("Miau...miau...!");
        }
    }
    public class Cachorro : Animal {
        public double Altura{ get; set; }
        public Cachorro(string nome) : base(nome){
            Nome = nome;
        }
        public Cachorro(string nome, double altura) : this(nome){
            Altura = altura;
        }
        public override string ToString(){
            return $"{Nome} tem {Altura}cm de altura!";
        }
        public void Latir(){
            Console.WriteLine("Au au au...au au au!");
        }
    }
    class ConstrutorThis{
        public static void Executar() {
            var cachorro = new Cachorro("Belinha", 50.0);
            var gato = new Gato("Bob", 40.0);
            Console.WriteLine("Cachorro...");
            Console.WriteLine(cachorro);
            Console.WriteLine(cachorro.Latir());
            Console.WriteLine("Gato...");
            Console.WriteLine(gato);
            Console.WriteLine(gato.Miau());
        }
    }



}