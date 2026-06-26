using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class ConversorDeTemperatura {

        // Celsius para Fahrenheit
        public double CelsiusParaFahrenheit(double celsius) {
            return (celsius * 9 / 5) + 32;
        }

        // Fahrenheit para Celsius
        public double FahrenheitParaCelsius(double fahrenheit) {
            return (fahrenheit - 32) * 5 / 9;
        }

        // Celsius para Kelvin
        public double CelsiusParaKelvin(double celsius) {
            return celsius + 273.15;
        }

        // Kelvin para Celsius
        public double KelvinParaCelsius(double kelvin) {
            return kelvin - 273.15;
        }
    

    
        public static void Executar() {

            var conversor = new ConversorTemperatura();

            Console.WriteLine("25°C em Fahrenheit: " +
                conversor.CelsiusParaFahrenheit(25));

            Console.WriteLine("77°F em Celsius: " +
                conversor.FahrenheitParaCelsius(77));

            Console.WriteLine("25°C em Kelvin: " +
                conversor.CelsiusParaKelvin(25));

            Console.WriteLine("300 K em Celsius: " +
                conversor.KelvinParaCelsius(300));
        }
    }
}