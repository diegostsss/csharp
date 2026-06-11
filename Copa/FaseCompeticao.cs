using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Copa {
    internal class FaseCompeticao {
        public static void Executar() {
            Console.Write("Pontos da seleção: ");
            int pontos = int.Parse(Console.ReadLine());

            if (pontos <= 3) {
                Console.WriteLine("Seleção Eliminada");
            } else if (pontos <= 6) {
                Console.Write("Saldo de gols: ");
                int saldo = int.Parse(Console.ReadLine());

                if (saldo > 3)
                    Console.WriteLine("Classificada");
                else
                    Console.WriteLine("Repescagem");
            } else {
                Console.WriteLine("Classificada diretamente");
            }
        }
    }
}