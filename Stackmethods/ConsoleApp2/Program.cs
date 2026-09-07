using System.Globalization;

namespace ConsoleApp2
{
    internal class Stackmethods
    {
        static void Main(string[] args)
        {
            Stack <int> stack = new Stack<int>();
            Console.Write("Enter the size of the stack: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter the element " + (i + 1) + ": ");
                int element = int.Parse(Console.ReadLine());
                stack.Push(element);
            }
            Console.WriteLine("\nElements in the stack are: ");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            int top = stack.Pop();
            Console.WriteLine("\nThe top element is: " + top);
            Console.WriteLine("\nAfter popping the top element, the elements in the stack are: "); 
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            int peek2 = stack.Peek();
            Console.WriteLine("\nThe top element is: " + peek2);
            bool exists = stack.Contains(30);
            Console.WriteLine("\nDoes the stack contain 30? : " + exists);
            int count = stack.Count;
            Console.WriteLine("\nThe number of elements in the stack is: " + count);
            stack.Clear();
        }
    }
}
