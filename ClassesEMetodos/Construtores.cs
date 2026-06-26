using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Cliente {
        public string Nome;
        public int Idade;
        public string Cpf;
        public string Email;
        public string Endereco;

        public Cliente(string nome, int idade, string cpf, string email, string endereco) {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Email = email;
            Endereco = endereco;
        }
    }

    internal class Construtores {
        public static void Executar() {

            var cliente1 = new Cliente(
                "Neymar",
                34,
                "444.333.222-67",
                "neymarjr@aura.com.br",
                "Vila Belmiro - Santos"
                );
            Console.WriteLine($"Qual é o CVV do cliente {cliente1.Nome} ?");

        }

    }
}
