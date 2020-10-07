using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos{
    public class AutomovelOpcoes{
        double desconto = 0.1;
        string nome;
        public string Nome{ 
            get{
                return "Opção: " + nome;
        } 
        set{
            nome = value;
        } }
        //Propriedade alto implementada
        public double Preco {get; set;}
        //Somente leitura
        public double PrecoComDesconto{
            get=> Preco - (desconto * Preco); //Lambda
        }
        public AutomovelOpcoes(){}
        public AutomovelOpcoes(string nome, double preco){
            Nome = nome;
            Preco = preco;
        }



    }
    class Props{
        public static void Executar(){
            var op1 = new AutomovelOpcoes("Ar Condicionado", 3550.9);
            Console.WriteLine(op1.PrecoComDesconto);
            var op2 = new AutomovelOpcoes();
            op2.Nome = "Câmbio automático";
            op2.Preco = 2450.9;
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.Writeline(op2.Nome);
            Console.Writeline(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }

}