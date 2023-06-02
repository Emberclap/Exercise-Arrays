namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfNumbers = Console.ReadLine().Split().ToArray();
            int rotations = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < rotations; i++)
            {
                string temporary = arrayOfNumbers[0];
                for (int j = 0; j < arrayOfNumbers.Length - 1; j++)
                {
                    
                    arrayOfNumbers[j] = arrayOfNumbers[j + 1];
                }
                arrayOfNumbers[arrayOfNumbers.Length - 1] = temporary;

            }
            Console.Write(string.Join(" ", arrayOfNumbers));
        }
    }
}