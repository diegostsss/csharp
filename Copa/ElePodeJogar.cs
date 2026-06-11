using System;

class ElePodeJogar {
    public static void Executar() { 
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Tem lesão? (s/n): ");
        string lesao = Console.ReadLine().ToLower();

        if (idade >= 18 && idade <= 40) {
            if (lesao == "n")
                Console.WriteLine("Pode jogar");
            else
                Console.WriteLine("Aguardando recuperação");
        } else {
            Console.WriteLine("Fora da convocação");
        }
    }
}