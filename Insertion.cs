using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Insertion: Program
    {
        public void InsertionSort()
        {
            int[] arr = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(100);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int k = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = k;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
