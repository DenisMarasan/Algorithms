using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
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
            BubbleSort(array);
            Print(array, "Sorted array:");

            Console.ReadKey();

            void BubbleSort(int[] ints)
            {
                for (int i = 0; i < ints.Length; i++)
                {
                    bool sortingRequired = false;

                    for (int j = 0; j < ints.Length - 1 - i; j++)
                    {
                        if (ints[j] > ints[j + 1])
                        {
                            int tmpValue = ints[j];
                            ints[j] = ints[j + 1];
                            ints[j + 1] = tmpValue;
                    
                            sortingRequired = true;
                        }
                    }

                    if (!sortingRequired)
                        break;
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
