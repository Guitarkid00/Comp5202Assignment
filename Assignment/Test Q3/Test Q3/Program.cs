using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code by Layton Vincent-Stewart   29/10/2018

            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = new int[3, 3];
            Random rnd = new Random();

            Console.WriteLine("Array 1");
            for(int i = 0; i < array1.GetLength(0); i++) // row
            {
                for(int j = 0; j < array1.GetLength(1); j++) // column
                {
                    array1[i, j] = rnd.Next(-10, 10); // setting the random number in the array
                    Console.WriteLine($"{array1[i, j]}");
                }
            }

            Console.WriteLine("Array 2");
            for (int i = 0; i < array2.GetLength(0); i++) // row
            {
                for (int j = 0; j < array2.GetLength(1); j++) // column
                {
                    array2[i, j] = rnd.Next(-10, 10); // setting the random number in the array
                    Console.WriteLine($"{array2[i, j]}");
                }
            }

            Console.WriteLine("Array 3");
            for (int i = 0; i < array3.GetLength(0); i++) // row
            {
                for (int j = 0; j < array3.GetLength(1); j++) // Column
                {
                    array3[i, j] = array1[i, j] + array2[i, j]; // Adding array1 and array2 to fill in the spaces in array3
                    Console.WriteLine($"{array3[i, j]}");
                }
            }
            Console.ReadLine(); // So the program doesn't close automatically
        }
    }
}
