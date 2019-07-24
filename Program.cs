using System;

namespace SortArrayName
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] data = new string[2, 2];
            string[] metaData = { "ime", "priimek" };
            for (int person = 0; person < data.GetLength(0); person++)
            {
                for (int attribute = 0; attribute < data.GetLength(1); attribute++)
                {
                    Console.WriteLine($"Vpiši {metaData[attribute]} za osebo {person + 1}. :");
                    data[person, attribute] = Console.ReadLine();
                }
            }

            for (int i = 0; i < data.GetLength(0); i++)
            {

                Console.Write(i + 1 + ". ");
                for (int j = 0; j < data.GetLength(0); j++)
                {
                    Console.Write($"{data[i, j]}" + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
