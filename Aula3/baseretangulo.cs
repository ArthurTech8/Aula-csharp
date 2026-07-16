using.System;

namespace.ConsoleApp1.Aula3
{
    internal class baseretangulo
    {
        static void Main()
        {
            Console.Write("Digite a base do retângulo: ");
            double BaseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double AlturaRetangulo = Convert.ToDouble(Console.ReadLine());

            int multiplicacao = BaseRetangulo * AlturaRetangulo;
            Console.Write($" A área do retângulo é: {multiplicacao}");
        }
    }
}