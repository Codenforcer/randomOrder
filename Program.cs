// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace randomOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniatialise an array with 10 indexes.
            int[] array = new int[10];
            // Random
            Random r = new Random();
            // For loop to ask user input and save numbers to array - loops 10 times.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please input a number: ");
                array[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            // For loop that swaps array[i] with a radom generated index using temp variable.
            for (int i = 0; i < array.Length; i++)
            {
                int j = r.Next(0, i + 1);

                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            // For loop that now prints out an array.
            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            
        }
    }
}

