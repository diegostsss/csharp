using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            var pessoa1 = new Pessoa();
            pessoa1.Nome = "Neyamr Jr";
            pessoa1.Idade = 34;

            var pessoa2 = new Pessoa();
            pessoa2.Nome = "Messi";
            pessoa2.Idade = 38;
            
            pessoa1.ApresentarNoConsole();
            pessoa2.ApresentarNoConsole();


        }


    }
}

       
    

    

