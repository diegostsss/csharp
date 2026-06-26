using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Atividade {
    internal class Jogador {

        public string Nome;
        public string Selecao;
        public int NumeroCamisa;
        public string Continente;
        public string ComidaTipica;

        public string apresentar() {
            return string.Format($"Olá! Me chamo {Nome}, jogo pela seleção {Selecao}, uso a camisa número {NumeroCamisa}, meu continente é {Continente} e minha comida típica é {ComidaTipica}");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(apresentar());
        }


    }
}
