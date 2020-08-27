using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Program
    {

        public static int size;
        public static System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        public static double elapsedTime;


        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter the size of an array that you want to sort:");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select which algorithm you want to perform:\n 1. Insertion sort" +
                "\n 2. Bubble sort \n 3. Merge sort \n 4. All\n");

            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Insertion sort");
                    Insertion sort = new Insertion();
                    watch.Reset();
                    watch.Start();
                    sort.InsertionSort();
                    watch.Stop();
                    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
                    Console.WriteLine("\nInsertion sort runtime: {0:F3}", elapsedTime);
                    Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
                    break;

                case 2:
                    Console.WriteLine("Bubble sort");
                    Bubble time = new Bubble();
                    watch.Reset();
                    watch.Start();
                    time.BubbleSort();
                    watch.Stop();
                    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
                    Console.WriteLine("\nBubble sort runtime: {0:F3}", elapsedTime);
                    Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
                    break;

                case 3:
                    Console.WriteLine("Merge sort");
                    Merge elem = new Merge();
                    watch.Reset();
                    watch.Start();
                    int[] arr = new int[size];
                    Random random = new Random();
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = random.Next(100);
                        Console.Write("{0} ", arr[i]);
                    }
                    Console.WriteLine("\n");
                    elem.mergeSort(arr, 0, size - 1);
                    watch.Stop();
                    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
                    Console.WriteLine("\nMerge sort runtime: {0:F3}", elapsedTime);
                    Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
                    break;

                case 4:
                    Console.WriteLine("All Sorting algorithms:");
                    Console.WriteLine("Insertion sort");
                    Insertion ins = new Insertion();
                    watch.Reset();
                    watch.Start();
                    ins.InsertionSort();
                    watch.Stop();
                    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
                    Console.WriteLine("\nInsertion sort runtime: {0:F3}", elapsedTime);
                    Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));

                    Console.WriteLine("\nBubble sort");
                    Bubble bub = new Bubble();
                    watch.Reset();
                    watch.Start();
                    bub.BubbleSort();
                    watch.Stop();
                    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
                    Console.WriteLine("\nBubble sort runtime: {0:F3}", elapsedTime);
                    Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));

                    Console.WriteLine("Merge sort");
                    Merge merge = new Merge();
                    watch.Reset();
                    watch.Start();
                    int[] array = new int[size];
                    Random ran = new Random();
                    for (int i = 0; i < size; i++)
                    {
                        array[i] = ran.Next(100);
                        Console.Write("{0} ", array[i]);
                    }
                    Console.WriteLine("\n");
                    merge.mergeSort(array, 0, size - 1);
                    watch.Stop();
                    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
                    Console.WriteLine("\nMerge sort runtime: {0:F3}", elapsedTime);
                    Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
                    break;

                default:
                    {
                        Console.WriteLine("Wrong selection");
                        break;
                    };

            }

        }


    }

}
