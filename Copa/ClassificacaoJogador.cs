using System;

namespace CursoCSharp.Copa {
    class ClassificacaoJogador {
        public static void Executar() {

            Console.Write("Digite a quantidade de gols: ");
            int gols = int.Parse(Console.ReadLine());

            if (gols >= 10)
                Console.WriteLine("Titular da seleção!");
            else if (gols >= 5)
                Console.WriteLine("Reserva");
            else
                Console.WriteLine("Não classificado");
        }
    }
}