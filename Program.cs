using System;

namespace SortArrayName
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] data = new string[2, 2];

            for(int name = 0; name < data.GetLength(0); name++)
            {
                for (int lastName = 0; lastName < data.GetLength(1); lastName++)
                {
                    Console.WriteLine($"Ime in priimek za {name + 1}. :");
                    data[name , lastName] = Console.ReadLine();
                }
            }

            for (int i = 0; i < data.GetLength(0); i++)
            {

                Console.Write(i+1 + ". ");
                for (int j = 0; j < data.GetLength(0); j++)
                {
                    Console.Write($"{data[i, j]}" + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
