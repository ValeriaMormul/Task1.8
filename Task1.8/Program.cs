using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть значення: "); //Введенняя значення n
        int n = int.Parse(Console.ReadLine());
        int sum = CalculateSumOfFirstNNumbers(n);
        Console.WriteLine($"Сума перших {n} натуральних чисел: {sum}");
    }
    static int CalculateSumOfFirstNNumbers(int n)
    {
        return n * (n + 1) / 2;
    }
}
