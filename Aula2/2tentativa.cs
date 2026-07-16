using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Aula2
{
    internal class _2tentativa
    {
        static void Main4()
        {
            Console.Title = "Calculadora em C#";

            Console.WriteLine("=================================");
            Console.WriteLine("      CALCULADORA EM C#");
            Console.WriteLine("=================================");

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("[1] Soma (+)");
            Console.WriteLine("[2] Subtração (-)");
            Console.WriteLine("[3] Multiplicação (*)");
            Console.WriteLine("[4] Divisão (/)");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine($"\nResultado: {numero1} + {numero2} = {resultado}");
                    break;

                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine($"\nResultado: {numero1} - {numero2} = {resultado}");
                    break;

                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"\nResultado: {numero1} × {numero2} = {resultado}");
                    break;

                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"\nResultado: {numero1} ÷ {numero2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("\nErro: não é possível dividir por zero.");
                    }
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

