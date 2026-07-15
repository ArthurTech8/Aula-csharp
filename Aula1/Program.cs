using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        int a = 24;

        if (idade >= 24)
        {
            Console.WriteLine($"Olá, {nome}! Você é maior de idade. Tem {idade}");
        }
        else if (idade <= 12)

            Console.WriteLine($"Olá, {nome}! Você é menor de idade. Tem {idade}");
    }
        else
        {
            Console.WriteLine($"Olá, {nome}! Você é adolescente. Tem {idade}");
        }
Console.WriteLine($"A vida está passando, {nome}!");
Console.WriteLine($"Já foram {idade} anos de vida.");
    }
}

teste commit
