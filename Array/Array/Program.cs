namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numberarray = new int[size];
            for (int i = 0; i < size; i++) {   
                Console.Write("Enter element " + (i + 1) + ": ");
                numberarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("The elements of the array are: ");
            for (int i = 0; i < size; i++) {
                Console.Write(numberarray[i] + " ");
            }
        }
    }
}
