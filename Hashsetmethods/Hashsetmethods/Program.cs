namespace Hashsetmethods;
class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(20);

        Console.WriteLine("HashSet:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nContains 20: " + numbers.Contains(20));

        numbers.Remove(20);
        Console.WriteLine("After Remove(20):");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Count: " + numbers.Count);

        numbers.IntersectWith(new int[] { 40, 50, 60 });
        Console.WriteLine("\nAfter IntersectWith {40, 50, 60}:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
        numbers.ExceptWith(new int[] { 10, 20 });
        Console.WriteLine("\nAfter ExceptWith {10, 20} :");
        foreach (int n in numbers)
        {  
            Console.WriteLine(n); 
        }
        numbers.Clear();
        Console.WriteLine("\nAfter Clear(), Count: " + numbers.Count);
    }
}