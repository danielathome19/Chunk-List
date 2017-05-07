using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Chunk_List
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeTrial();
            Console.ReadKey();
        }

        public static void TimeTrial()
        {

            Console.WriteLine("Starting");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            ChunkList<int> list = new ChunkList<int>(50000);

            Random rand = new Random();

            for (int i = 0; i < 500000; i++)
            {
                list.add(rand.Next(0, 10));
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(list.contains(3));
            Console.WriteLine(list.contains(6));
            Console.WriteLine(list.contains(500));
            Console.WriteLine();
            Console.WriteLine(list.size());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Sorted:");
            list.sort();

            list.remove(7);
            list.removeAll(3);

            Console.WriteLine();
            Console.WriteLine();

            stopwatch.Stop();

            Console.WriteLine("\nCompletely done");
            Console.WriteLine("[Elapsed time - Chunk List] Minutes: " + stopwatch.Elapsed.Minutes + " Seconds: " + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);

            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            List<int> list2 = new List<int>();

            for (int i = 0; i < 500000; i++)
            {
                list2.Add(rand.Next(0, 10));
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(list2.Contains(3));
            Console.WriteLine(list2.Contains(6));
            Console.WriteLine(list2.Contains(500));
            Console.WriteLine();
            Console.WriteLine(list2.Count);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Sorted:");
            list2.Sort();

            list2.Remove(7);
            list2.RemoveAll(item => item == 3);

            stopwatch2.Stop();

            Console.WriteLine("\nCompletely done");
            Console.WriteLine("[Elapsed time - Array List] Minutes: " + stopwatch2.Elapsed.Minutes + " Seconds: " + stopwatch2.Elapsed.Seconds + "." + stopwatch2.Elapsed.Milliseconds);

            Console.WriteLine();
            double time1 = Convert.ToDouble(stopwatch.Elapsed.Seconds.ToString() + stopwatch.Elapsed.Milliseconds.ToString().Substring(0, 2));
            double time2 = Convert.ToDouble(stopwatch2.Elapsed.Seconds.ToString() + stopwatch2.Elapsed.Milliseconds.ToString().Substring(0, 2));

            Console.WriteLine(time1 < time2 ? "Chunk List ran " + Math.Round((time2 / time1), 2) + "x faster than Array List" : "Chunk List ran " + Math.Round((time1 / time2), 2) + "x slower than Array List");
        }

        public static void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
