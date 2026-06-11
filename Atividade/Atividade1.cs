using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Atividade {

    internal class Al {

        public static void Executar() {

            int quantidadeJogos;
            int gols;
            int totalGols = 0;

            Console.Write("Quantos jogos deseja registrar? ");
            quantidadeJogos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeJogos; i++) {
                Console.Write($"Jogo {i}: ");
                gols = int.Parse(Console.ReadLine());

                totalGols += gols;
            }


            Console.WriteLine($"\nTotal de gols: {totalGols}");

        }
    }
}