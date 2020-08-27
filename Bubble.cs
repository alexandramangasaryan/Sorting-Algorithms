using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{

    class Bubble : Program
    {
        public void BubbleSort()
        {
            int[] arr = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(100);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int k = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = k;
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
