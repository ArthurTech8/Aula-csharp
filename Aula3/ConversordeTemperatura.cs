using System;

class ConversordeTemperatura
{
    static void Main()
    {
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit} °F");
        //Console.ReadKey();

        double celsiusconv = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"A temperatura em Celsius é: {celsiusconv} °");
        Console.ReadKey();
    }

} 