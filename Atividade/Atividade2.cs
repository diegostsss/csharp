using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Atividade {

    internal class Copa1 {
        public static void Executar() {
            
                Console.Write("Digite quantos dias faltam para o jogo: ");
                int dias = int.Parse(Console.ReadLine());

                for (int i = dias; i >= 1; i--) {
                    Console.WriteLine($"Faltam {i} dias para o jogo");
                

                Console.WriteLine("O jogo começou!");
            }

        }
    }
}