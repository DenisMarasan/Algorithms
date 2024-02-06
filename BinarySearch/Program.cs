using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[100];
            var bs = new BinarySearch();

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i + 1;
            }

            Console.WriteLine($"Pick an integer number from 1 to {ints.Length}");
            int yourNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your picked: {bs.Search(ints, yourNumber)}");
            Console.ReadKey();
        }
    }

    class BinarySearch
    {
        public int Search(int[] array, int x)
        {
            int tmpIndex = 0;
            int minIndex = 0;
            int maxIndex = array.Length - 1;

            while (array[tmpIndex] != x)
            {
                tmpIndex = minIndex + (maxIndex - minIndex) / 2;

                if (array[tmpIndex] == x)
                    return array[tmpIndex];

                Check();
            }

            void Check()
            {
                Console.WriteLine($"Is the number you picked greater than {array[tmpIndex]}? Y/N");

                if (Console.ReadLine() == "y")
                    minIndex = tmpIndex;
                else
                    maxIndex = tmpIndex;
            }

            throw new Exception($"Index {tmpIndex} is out of range");
        }
    }
}
