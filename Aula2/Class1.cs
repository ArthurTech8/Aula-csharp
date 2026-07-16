using System;
namespace Aula2

{
    class Program
    {
        static void Main3()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite por quanto quer subtrair: ");
            int numero3 = int.Parse(Console.ReadLine());

            Console.Write("Digite por quanto quer multiplicar: ");
            int numero4 = int.Parse(Console.ReadLine());

            Console.Write("Digite por quanto quer Dividir: ");
            int numero5 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;
            Console.Write($" A soma é: {soma}");

            int subtracao = soma - numero3;
            Console.Write($" A subtração é: {subtracao}");

            int multiplicacao = subtracao * numero4;
            Console.Write($" A multiplicação é: {multiplicacao}");

            int divisao = multiplicacao / numero5;
            Console.Write($" A divisão é: {divisao}");


        }
    }

}
