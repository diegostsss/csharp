using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Atividade {
    internal class Copa3 {
        public static void Executar() {
          
                string artilheiro = "";
                int maiorGols = -1;

                for (int i = 1; i <= 5; i++) {
                    Console.Write($"Digite o nome do jogador {i}: ");
                    string nome = Console.ReadLine();

                    Console.Write($"Digite a quantidade de gols de {nome}: ");
                    int gols = int.Parse(Console.ReadLine());

                    if (gols > maiorGols) {
                        maiorGols = gols;
                        artilheiro = nome;
                    }
                }

                Console.WriteLine($"\nArtilheiro: {artilheiro} com {maiorGols} gols"); 
        }
    }
}
    