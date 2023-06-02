using System.Security.Cryptography;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); 
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            
            for (int i = 0; i < n; i++) 
            {
                string[] numbers = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    array1[i] = int.Parse(numbers[0]);
                    array2[i] = int.Parse(numbers[1]);
                }
                else
                {
                    array1[i] = int.Parse(numbers[1]);
                    array2[i] = int.Parse(numbers[0]);
                }
            }
            for (int i = 0;i < n; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array2[i]} ");
            }
        }
    }
}