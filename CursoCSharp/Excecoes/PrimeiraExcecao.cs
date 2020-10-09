using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes{
    public class Conta{
        double Saldo;
        public Conta(double saldo){
            Saldo = saldo;
        }
        public void Sacar(double saldo){
            if(valor>Saldo){
                throw new ArgumentException("Saldo Insuficiente");
            }
            Saldo -= valor;
        }
    }
    
    class PrimeiraExcecao{
        public static void Executar() {
            var cont = new Conta(1_500.85);
            try{
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }catch(Exception ex){
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }finally{
                Console.WriteLine("Obrigado!");
            }
        }
    }
}