namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < integers.Length; i++)
            {
                for (int j = i + 1; j < integers.Length; j++)
                {
                    if (integers[i] + integers[j] == number)
                    {
                        Console.WriteLine($"{integers[i]} {integers[j]}");
                    }
                }
                
            }
        }
    }
}