using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть значення x:");

        string input = Console.ReadLine();

        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Потрiбно було ввести число");
            return;
        }

        if (!double.TryParse(input, out double x))
        {
            Console.WriteLine("Некоректне введення числа");
            return;
        }

        
        Func<double, double> F1 = x => 4 * x - 1; // Для x <= 0
        Func<double, double> F2 = x => 25 * x + 10; // Для x > 0

        
        double result = x <= 0 ? F1(x) : F2(x);

        Console.WriteLine($"Результат обчислення F({x}) = {result}");
    }
}
