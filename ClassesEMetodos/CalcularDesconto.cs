using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.ClassesEMetodos {
    class Calculadora {

        public static double Desconto(double preco, double percentual) {
            return preco - (preco * percentual / 100);

        }

    }

    internal class CalcularDesconto {

        public static void Executar() {

            double precoProduto = 67.00;
            double precoComDesconto = Calculadora.Desconto(precoProduto, 67);
            Console.WriteLine($"Preço original R${precoProduto:F2}");
            Console.WriteLine($"Preço com desconto R${precoComDesconto:F2}");

        }

    }
}



