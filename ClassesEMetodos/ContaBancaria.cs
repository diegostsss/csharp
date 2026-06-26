using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class ContaCliente {

        public string Titular;
        public double Saldo;

        public ContaCliente(string titular, double saldo) {
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double valor) {
            Saldo += valor;
            
        }
        public void Sacar(double valor) {
            Saldo -= valor;
        }

        public void mostrarSaldo() {
            Console.WriteLine($"Titular: {Titular}, Saldo: R${Saldo:F2}");
        }
    }

    internal class ContaBancaria {

        public static void Executar(){

            ContaCliente conta1 = new ContaCliente("Neymar", 6000);
            ContaCliente conta2 = new ContaCliente("Caça Rato", 10);

            conta1.Depositar(500);
            conta1.Sacar(10);

            conta1.mostrarSaldo();

            conta2.Depositar(1000000);
            conta2.Sacar(500);

            conta2.mostrarSaldo();
        }

    }
}
