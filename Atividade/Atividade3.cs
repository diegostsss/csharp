using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Atividade {
    internal class Copa2 {
        public static void Executar() {
           
                int soma = 0;

                for (int i = 1; i <= 5; i++) {
                    Console.Write($"Digite os gols da partida {i}: ");
                    int gols = int.Parse(Console.ReadLine());

                    soma += gols;
                }

                double media = (double)soma / 5;

                Console.WriteLine($"Média de gols: {media}");
         }
     }
}
    