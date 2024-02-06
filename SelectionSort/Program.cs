using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array =
            {
                345,
                6547,
                235,
                456,
                567,
                3245,
                5436,
                234,
                456,
                465
            };

            Print(array, "Unsorted array:");
            SelectionSort(array);
            Print(array, "Sorted array:");

            Console.ReadKey();

            void SelectionSort(int[] ints)
            {
                int minIndex = 0;
                int tmpValue = 0;

                for (int i = 0; i < ints.Length; i++)
                {
                    int minValue = int.MaxValue;
                    int jStartIndex = i;

                    for (int j = jStartIndex; j < ints.Length; j++)
                    {
                        if (ints[j] < minValue)
                        {
                            minValue = ints[j];
                            minIndex = j;
                        }
                    }

                    tmpValue = ints[jStartIndex];
                    ints[jStartIndex] = ints[minIndex];
                    ints[minIndex] = tmpValue;
                }
            }

            void Print(int[] ints, string title)
            {
                Console.WriteLine($"{title}");

                for (int i = 0; i < ints.Length; i++)
                {
                    Console.WriteLine(ints[i]);
                }

                Console.WriteLine("\n");
            }
        }
    }
}
