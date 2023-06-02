namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int biggestCount = 0;
            int equals = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;
                
                for (int j = i; j < numbers.Length; j++)
                {
                    
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        if (counter > biggestCount)
                        {
                            biggestCount = counter;
                            equals = numbers[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                
                
            }
            for (int i = 0; i < biggestCount; i++)
            {
                Console.Write($"{equals} ");
            }
            
        }
    }
}