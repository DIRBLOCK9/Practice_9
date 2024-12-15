using System;

class Program
{
    static void Main()
    {
        
        Predicate<int> isEven = number => number % 2 == 0;

        
        Console.WriteLine("Введiть цiле число:");
        if (!int.TryParse(Console.ReadLine(), out int input))
        {
            Console.WriteLine("Некоректне введення числа.");
            return;
        }

        
        bool result = isEven(input);

        
        Console.WriteLine(result
            ? $"Число {input} є парним."
            : $"Число {input} не є парним.");
    }
}
