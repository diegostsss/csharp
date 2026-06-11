using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Copa {

    internal class VendaIngressos {
        public static void Executar() {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade de ingressos: ");
            int qtd = int.Parse(Console.ReadLine());

            double total = qtd * 120;
            double desconto = 0;

            if (qtd > 5)
                desconto = total * 0.10;

            double final = total - desconto;

            Console.WriteLine($"Valor Total: R$ {total:F2}");
            Console.WriteLine($"Desconto: R$ {desconto:F2}");
            Console.WriteLine($"Valor Final: R$ {final:F2}");
        }
    }
}