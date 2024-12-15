using System;

class Program
{
    static void Main()
    {
        
        Func<double, double, double> findMin = (a, b) => a < b ? a : b;

        
        Console.WriteLine("Введiть перше число:");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Некоректне введення числа.");
            return;
        }

        Console.WriteLine("Введiть друге число:");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Некоректне введення числа.");
            return;
        }

        
        double result = findMin(num1, num2);

        
        Console.WriteLine($"Менше з двох чисел: {result}");
    }
}

