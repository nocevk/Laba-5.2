using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1
            {
               
                int[] array = new int[30];
                Random rand = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-10, 10); 
                }

               
                Console.WriteLine("Початковий масив:");
                PrintArray(array);

                int minIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[minIndex])
                    {
                        minIndex = i;
                    }
                }

                Console.WriteLine($"\nПерший мінімальний елемент: {array[minIndex]} на індексі {minIndex}");

                BubbleSortDescending(array, minIndex + 1);

                Console.WriteLine("\nПеретворений масив:");
                PrintArray(array);
            }

            void BubbleSortDescending(int[] array, int startIndex)
            {
                int n = array.Length;
                for (int i = startIndex; i < n - 1; i++)
                {
                    for (int j = startIndex; j < n - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



