using System;

class ConvocacaoSelecao {
    public static void Executar() {
     
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de gols: ");
        int gols = int.Parse(Console.ReadLine());

        if (idade >= 18 && idade <= 35) {
            if (gols >= 20)
                Console.WriteLine("Convocado");
            else
                Console.WriteLine("Lista de espera");
        } else {
            Console.WriteLine("Não convocado");
        }
    }
}