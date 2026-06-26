using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class OrdemServico {
        public string Cliente;
        public string Modelo;
        public double ValorPecas;
        public double ValorMaoDeObra;
        public string Telefone;
        public string contrato;


        public OrdemServico(string cliente, string modelo, double valorPecas, double valorMaoDeObra) {

            Cliente = cliente;
            Modelo = modelo;
            ValorPecas = valorPecas;
            ValorMaoDeObra = valorMaoDeObra;
         

        }

        public double CalcularTotal() {
            return ValorPecas + ValorMaoDeObra;
        }
        public double CalcularDesconto() {
            double total = CalcularTotal();
            if(total >= 6767) {
                return total * 0.67;

            } else {
                return total * 0.05;
            }
       
    }
        public double CalcularValorFinal() {
            return CalcularTotal() - CalcularDesconto();
        }
        public void mostrarOrdem() {
            Console.WriteLine($"Cliente: {Cliente}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Valor das Peças: R${ValorPecas:F2}");
            Console.WriteLine($"Valor da Mão de Obra: R${ValorMaoDeObra:F2}");
            Console.WriteLine($"Total: R${CalcularTotal():F2}");
            Console.WriteLine($"Desconto: R${CalcularDesconto():F2}");
            Console.WriteLine($"Valor Final: R${CalcularValorFinal():F2}");
        }

        internal class OficinaMecanica {

        public static void Executar() {
                OrdemServico servico1
                = new OrdemServico("Neymar", "Mclaren", 1000, 10);

                OrdemServico servico2
               = new OrdemServico("Junior", "Porsche", 5000, 67000);

                servico1.mostrarOrdem();
                servico2.mostrarOrdem();

            }

    }

}
}