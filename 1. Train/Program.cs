namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peoplePerWagon = new int[wagons];
            int allPeople = 0;

            for (int i = 0; i < wagons; i++)
            {
                peoplePerWagon[i] = int.Parse(Console.ReadLine());
                allPeople += peoplePerWagon[i];
                
            }
            for (int i = 0;i < peoplePerWagon.Length;i++)
            {
                Console.Write($"{peoplePerWagon[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{allPeople}");
        }
    }
}