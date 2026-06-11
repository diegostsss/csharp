using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estruturas {

    internal class EstruturaRepeticao {

        public static void Executar() {
            {
                int contador = 1;

                Console.WriteLine("Digite uma senha ");
                string password = Console.ReadLine();

                while (password != "7taz9hvj") {
                    Console.WriteLine("Senha incorreta, digite novamente");
                    password = Console.ReadLine();
                    if (password == "7taz9Hvj") {
                        Console.WriteLine("Senha correta! Bem-vindo à seleção de pontos!");
                        break;
                    } else {
                        Console.WriteLine("Senha incorreta! Acesso negado.");
                    }
                }
            }
        }
    }
}
    