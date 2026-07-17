using System;

class Baseretangulo
{
    static void Main5()
    {
        Console.Write("Digite a base do retângulo: ");
        double BaseRetangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        double AlturaRetangulo = Convert.ToDouble(Console.ReadLine());

        double multiplicacao = BaseRetangulo * AlturaRetangulo;
        Console.WriteLine($" A área do retângulo é: {multiplicacao}");
        Console.ReadKey();
    }
}
