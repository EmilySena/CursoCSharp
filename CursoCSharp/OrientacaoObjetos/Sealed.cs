using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OrientacaoObjetos {
    sealed class SemFilho{
        public double ValorFortuna(){
            return 1_500_900.85;
        }
    }
    class Avo{
        public virtual bool HonrarFamilia(){
            return true;
        }
    }
    class Pai : Avo{
        public override sealed bool HonrarFamilia() {
            return true;
        }
    }
    class FilhoRebelde : Pai{

    }
    class Sealed{
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorFortuna());
            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarFamilia());
        }
    }

}