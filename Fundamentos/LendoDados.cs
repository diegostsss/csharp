using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            Console.WriteLine("Digite o seu CVV?");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("O CVV do seu cartão é ",codigo);

            //formatando números

            double valor = 67.67676767;

            //arredondar números

            Console.WriteLine(valor.ToString("F1"));

            //valor monétario

            Console.WriteLine(valor.ToString("C"));

            //formatando do jeito que você quer

            Console.WriteLine(valor.ToString("#.###"));

            //porcentagem

            Console.WriteLine(valor.ToString("P"));
        }
    }
}
