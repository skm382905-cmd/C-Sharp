using System;

internal class PrimeNo
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        while (i < num)
        {
            if (num % i == 0)
            {
                Console.WriteLine("The number is not prime.");
                return;
            }
            i++;
        }
        Console.WriteLine("The number is prime.");
    }
}