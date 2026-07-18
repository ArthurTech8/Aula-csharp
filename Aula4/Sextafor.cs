using System;
class Sextafor
{
  


        //        Console.Write("Digite um numero: ");
        //        int numero = int.Parse(Console.ReadLine());

        //            Console.WriteLine("\nTabuada do {numero}\n");

        //        //Exiba os numeros de 1 até 100.
        //        for (int i = 1; i <= 10; i++)
        //        {
        //            Console.WriteLine($"{numero} x {i} = " + (numero * i));
        //        }
        //        Console.ReadKey();

        //    }

        //}      
        //Receba dois valores (parametros) e devolve um resultado (retorno) da multiplicação dos dois valores.



    static int Somar(int a, int b)
    {
        return a + b;
    }
        
    static int Main()
    {

        Console.Write("Digite o primeiro numero: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        int b = int.Parse(Console.ReadLine());

        int resultado = Somar(a, b);

        return resultado;

    }
        Console.ReadKey();    

}
