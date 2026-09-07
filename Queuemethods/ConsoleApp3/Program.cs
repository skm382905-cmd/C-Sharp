using System.Globalization;

namespace ConsoleApp2
{
    internal class Queuemethods
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Console.Write("Enter the size of the queue: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter the element " + (i + 1) + ": ");
                int element = int.Parse(Console.ReadLine());
                queue.Enqueue(element);
            }
            Console.WriteLine("\nElements in the queue are: ");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            int front = queue.Dequeue();
            Console.WriteLine("\nThe front element is: " + front);
            Console.WriteLine("\nAfter dequeuing the front element, the elements in the queue are: ");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            int peek2 = queue.Peek();
            Console.WriteLine("\nThe rear element is: " + peek2);
            bool exists = queue.Contains(30);
            Console.WriteLine("\nDoes the queue contain 30? : " + exists);
            int count = queue.Count;
            Console.WriteLine("\nThe number of elements in the queue is: " + count);
            queue.Clear();
        }
    }
}
