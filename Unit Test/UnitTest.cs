using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;
using Chunk_List;
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation.Evident

namespace Unit_Test
{
    public class ChunkListTest
    {
        private static void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.Write(item + " ");
            }
        }

        [Fact]
        public void ArrayListComparison()
        {
            Console.WriteLine("Starting");


            List<int> list2 = new List<int>();
            ChunkList<int> list = new ChunkList<int>(50000);
            ChunkList<int> list3 = new ChunkList<int>((int)Math.Sqrt(500000));

            Random rand = new Random();

            for (int i = 0; i < 500000; i++)
            {
                int x = rand.Next(0, 10);
                list.add(x);
                list2.Add(x);
                list3.add(x);
            }

            #region ChunkListTest
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("\n\n{0}\n{1}\n{2}\n\nSize: {3}\n\n", list.contains(3), list.contains(6), list.contains(500), list.size());
            Console.WriteLine("[Elapsed time - Chunk List] Minutes: " + stopwatch.Elapsed.Minutes + " Seconds: " + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);

            Console.WriteLine("Sorting & Removing:\n\n");

            list.sort();

            list.remove(7);
            list.removeAll(3);

            stopwatch.Stop();
            
            Console.WriteLine("Completely Done\n[Elapsed time - Chunk List] Minutes: " + stopwatch.Elapsed.Minutes + " Seconds: " + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);
            #endregion

            Console.WriteLine("\n******************************************************************");


            #region ChunkListSqrtTest
            var stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            Console.WriteLine("\n\n{0}\n{1}\n{2}\n\nSize: {3}\n\n", list.contains(3), list.contains(6), list.contains(500), list.size());
            Console.WriteLine("[Elapsed time - Chunk List Sqrt] Minutes: " + stopwatch3.Elapsed.Minutes + " Seconds: " + stopwatch3.Elapsed.Seconds + "." + stopwatch3.Elapsed.Milliseconds);

            Console.WriteLine("Sorting & Removing:\n\n");

            list.sort();

            list.remove(7);
            list.removeAll(3);

            stopwatch3.Stop();

            Console.WriteLine("Completely Done\n[Elapsed time - Chunk List Sqrt] Minutes: " + stopwatch3.Elapsed.Minutes + " Seconds: " + stopwatch3.Elapsed.Seconds + "." + stopwatch3.Elapsed.Milliseconds);
            #endregion

            Console.WriteLine("\n******************************************************************");

            #region ArrayListTest
            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Console.WriteLine("\n\n{0}\n{1}\n{2}\n\nSize: {3}\n\n", list2.Contains(3), list2.Contains(6), list2.Contains(500), list2.Count);
            Console.WriteLine("[Elapsed time - Array List] Minutes: " + stopwatch2.Elapsed.Minutes + " Seconds: " + stopwatch2.Elapsed.Seconds + "." + stopwatch2.Elapsed.Milliseconds);

            Console.WriteLine("Sorting & Removing:\n\n");

            list2.Sort();

            list2.Remove(7);

            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i] == 3)
                {
                    list2.RemoveAt(i);
                    i--;
                }
            }

            stopwatch2.Stop();
            
            Console.WriteLine("Completely Done\n[Elapsed time - Array List] Minutes: " + stopwatch2.Elapsed.Minutes + " Seconds: " + stopwatch2.Elapsed.Seconds + "." + stopwatch2.Elapsed.Milliseconds);
            #endregion

            Console.WriteLine("\n******************************************************************\n");
            
            double time1 = Convert.ToDouble(stopwatch.Elapsed.Seconds.ToString() + stopwatch.Elapsed.Milliseconds.ToString().Substring(0, 2));
            double time2 = Convert.ToDouble(stopwatch2.Elapsed.Seconds.ToString() + stopwatch2.Elapsed.Milliseconds.ToString().Substring(0, 2));
            double time3 = Convert.ToDouble(stopwatch3.Elapsed.Seconds.ToString() + stopwatch3.Elapsed.Milliseconds.ToString().Substring(0, 2));

            Assert.True(time1 < time2);

            Console.WriteLine(time1 < time2 ? "Chunk List ran " + Math.Round((time2 / time1), 2) + "x faster than Array List" : "Chunk List ran " + Math.Round((time1 / time2), 2) + "x slower than Array List");
            Console.WriteLine(time3 < time2 ? "Sqrt Chunk List ran " + Math.Round((time2 / time3), 2) + "x faster than Array List" : "Sqrt Chunk List ran " + Math.Round((time3 / time2), 2) + "x slower than Array List");
            Console.WriteLine(time1 < time3 ? "Chunk List ran " + Math.Round((time3 / time1), 2) + "x faster than Sqrt Chunk List" : "Chunk List ran " + Math.Round((time1 / time3), 2) + "x slower than Sqrt Chunk List");
        }

        [Fact]
        public void ChunkSizeComparison()
        {
            var list0 = new ChunkList<int>(10);
            var list1 = new ChunkList<int>(100);
            var list2 = new ChunkList<int>(500);
            var list3 = new ChunkList<int>(1000);
            var list4 = new ChunkList<int>(2500);
            var list5 = new ChunkList<int>(5000);
            var list6 = new ChunkList<int>(10000);
            var list7 = new ChunkList<int>(25000);
            var list8 = new ChunkList<int>(50000);
            var list9 = new ChunkList<int>(100000);
            var list10 = new ChunkList<int>(500000);
            
            Random rand = new Random();

            for (int i = 0; i < 500000; i++)
            {
                int x = rand.Next(0, 10);
                list0.add(x);
                list1.add(x);
                list2.add(x);
                list3.add(x);
                list4.add(x);
                list5.add(x);
                list6.add(x);
                list7.add(x);
                list8.add(x);
                list9.add(x);
                list10.add(x);
            }

            Stopwatch Test(ChunkList<int> list)
            {
                Console.WriteLine("Testing list of 500,000 items with chunk size of {0}", list.getChunkSize());
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                
                //Console.WriteLine("\n\n{0}\n{1}\n{2}\n\nSize: {3}\n\n", list.contains(3), list.contains(6), list.contains(500), list.size());
                //Console.WriteLine("[Elapsed time] Minutes: " + stopwatch.Elapsed.Minutes + " Seconds: " + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);
                //Console.WriteLine("Sorting & Removing:\n\n");
                
                list.sort();
                
                list.remove(7);
                list.removeAll(3);

                stopwatch.Stop();
            
                //Console.WriteLine("Completely Done\n[Elapsed time] Minutes: " + stopwatch.Elapsed.Minutes + " Seconds: " + stopwatch.Elapsed.Seconds + "." + stopwatch.Elapsed.Milliseconds);    
                //Console.WriteLine("\n******************************************************************\n");

                return stopwatch;
            }

            var resultArray = new[]
            {
                new {chunkSize = list0.getChunkSize(), time = Test(list0)},
                new {chunkSize = list1.getChunkSize(), time = Test(list1)},
                new {chunkSize = list2.getChunkSize(), time = Test(list2)},
                new {chunkSize = list3.getChunkSize(), time = Test(list3)},
                new {chunkSize = list4.getChunkSize(), time = Test(list4)},
                new {chunkSize = list5.getChunkSize(), time = Test(list5)},
                new {chunkSize = list6.getChunkSize(), time = Test(list6)},
                new {chunkSize = list7.getChunkSize(), time = Test(list7)},
                new {chunkSize = list8.getChunkSize(), time = Test(list8)},
                new {chunkSize = list9.getChunkSize(), time = Test(list9)},
                new {chunkSize = list10.getChunkSize(), time = Test(list10)}
            };

            foreach (var result in resultArray)
            {
                Console.WriteLine("Result for chunk size of " + result.chunkSize + ": " + result.time.Elapsed.Minutes + " Minutes, " + result.time.Elapsed.Seconds + "." + result.time.Elapsed.Milliseconds + " Seconds");
            } 
        }
    }
}
