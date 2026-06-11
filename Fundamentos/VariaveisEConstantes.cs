using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            //variavel
            double raio = 4.5;
            //constante
            const double pi = 3.14;

            double area = pi * raio * raio;


            int idade = 30;

            bool temGato = false;

            var nome = "Neymar";

            byte idadeNeymar = 34;//0 a 250
            sbyte saldo = -10;//-128 a 127
            uint salarioNey = 1000000000;
            long salarioRealNey = 10000000000;
            ulong salarioRealVerdadeiroNey = 1000000000000;
            DateTime dataNascimento = new DateTime(1992, 02, 05);

            Console.WriteLine("A área total é "+area);
            Console.WriteLine($"Neymar ganha {salarioRealVerdadeiroNey}");
        }
    }
}
