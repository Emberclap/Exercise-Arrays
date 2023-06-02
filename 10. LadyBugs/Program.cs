using System;
using System.Runtime.CompilerServices;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];

            int[] bugs = (Console.ReadLine().Split().Select(int.Parse).ToArray());
            for (int i = 0; i < bugs.Length; i++)
            {
                if (bugs[i] >= 0 && bugs[i] < field.Length)
                {
                    field[bugs[i]] = 1;
                }
            }

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                int bug = 0;
                int flyLenght = 0;

                string[] movements = new string(command).Split();
                bug = int.Parse(movements[0]);
                flyLenght = int.Parse(movements[2]);
                string direction = movements[1];

                if (bug < 0 || bug > field.Length - 1 ||  field[bug]==0)
                {
                    continue;
                }
                field[bug] = 0;
                if (direction == "right")
                {
                    int newPosition = bug + flyLenght;
                    
                    if (newPosition > field.Length-1)
                    {
                        continue;
                    }
                    if (field[newPosition] == 1)
                    {
                        while (field[newPosition] == 1)
                        {
                            newPosition += flyLenght;
                            if (newPosition > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (newPosition <= field.Length-1)
                    {
                        field[newPosition] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int newPosition = bug - flyLenght;
                    
                    if (newPosition < 0)
                    {
                        continue;
                    }
                    if (field[newPosition] == 1)
                    {
                        while (field[newPosition] == 1)
                        {
                            newPosition -= flyLenght;
                            if (newPosition < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (newPosition >= 0)
                    {
                        field[newPosition] = 1;
                    }

                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}