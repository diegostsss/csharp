using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEmetodos {

    internal class lanchonete {

        public static void Executar() {

            Console.WriteLine("Quantos lanches você quer pedir?");
            int qtde = int.Parse(Console.ReadLine());
            string[] lanches = new string[qtde];

            for (int contador = 0; contador < qtde; contador++) {
                Console.WriteLine($"Digite o {contador + 1} lanche: ");
                lanches[contador] = Console.ReadLine();

            }

            Console.WriteLine("Você pediu os seguintes lanches:");
            foreach (string lanche in lanches) {
                Console.WriteLine(lanche);

            }

        }

    }

}