namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("Enter element [" + i + "][" + j + "]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The elements of the array are: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}