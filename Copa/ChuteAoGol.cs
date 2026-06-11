using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Copa {

    internal class ChuteAoGol {
        public static void Executar() {
            Console.Write("Quantidade de chutes: ");
            double chutes = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de gols: ");
            double gols = double.Parse(Console.ReadLine());

            double aproveitamento = (gols / chutes) * 100;

            Console.WriteLine($"Aproveitamento: {aproveitamento:F2}%");

            if (aproveitamento < 20)
                Console.WriteLine("Ruim");
            else if (aproveitamento <= 50)
                Console.WriteLine("Bom");
            else
                Console.WriteLine("Excelente");
        }
    }
}