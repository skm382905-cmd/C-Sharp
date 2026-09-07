using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"After swapping: First number = {a}, Second number = {b}");
    }
}