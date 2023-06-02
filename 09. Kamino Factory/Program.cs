namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequences = int.Parse(Console.ReadLine());
            int sampleCounter = 0;
            int bestDNA = 0;
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            int[] bestDnaSequence = new int[lengthOfSequences];
            string sequences = Console.ReadLine();
            
            while (sequences != "Clone them!")
            {

                int[] DNA = new string(sequences).Split('!', StringSplitOptions.RemoveEmptyEntries) .Select(int.Parse).ToArray();
               
                sampleCounter++;
                int sequenceSum = 0;
                int sum = 0;
                int counter = 0;
                
                int sequenceIndex = 0;
                for (int i = 0; i < DNA.Length; i++)
                {
                    if (DNA[i] == 1)
                    {
                        counter++;
                        sum++;
                        if (counter >= 2)
                        {
                            sequenceIndex = i-1;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
                sequenceSum = sum;
                
                if (bestSequenceIndex == sequenceIndex && bestSequenceSum < sequenceSum)
                {
                    bestSequenceSum = sum;
                    bestDnaSequence = DNA;
                    bestSequenceIndex = sequenceIndex;
                    bestDNA = sampleCounter;
                }
                else if (sequenceIndex < bestSequenceIndex || sampleCounter == 1)
                {
                    bestSequenceSum = sum;
                    bestDnaSequence = DNA;
                    bestSequenceIndex = sequenceIndex;
                    bestDNA = sampleCounter;
                }
                
                sequences = Console.ReadLine();
                
            }
            Console.WriteLine($"Best DNA sample {bestDNA} with sum: {bestSequenceSum}.");
            Console.Write(string.Join(" ", bestDnaSequence));
        }
    }
}
