using BenchmarkDotNet.Attributes;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace benchmark
{
    [MemoryDiagnoser]
    public class MemoryBenchmarkerDemo
    {
        int NumberOfItems = 100000;
        [Benchmark]
        public Queue ConcatStringsUsingQueue()
        {
            var Queue = new Queue();

            for (int i = 0; i < NumberOfItems; i++)
            {
                Queue.Enqueue(i);
            }
            return Queue;
        }

        [Benchmark]
        public Stack ConcatStringsUsingStack()
        {
            var Stack = new Stack();

            for (int i = 0; i < NumberOfItems; i++)
            {
                Stack.Push(i);
            }
            return Stack;
        }

        [Benchmark]
        public Hashtable ConcatStringsUsingHashtable()
        {
            var Hashtable = new Hashtable();

            for (int i = 0; i < NumberOfItems; i++)
            {
                Hashtable.Add(i, i);
            }
            return Hashtable;
        }


        [Benchmark]
        public HashSet<int> ConcatStringsUsingHashSet()
        {
            var SortList = new HashSet<int>();

            for (int i = 0; i < NumberOfItems; i++)
            {
                SortList.Add(i);
            }
            return SortList;
        }


        [Benchmark]
        public SortedList ConcatStringsUsingSortedList()
        {
            var SortList = new SortedList();

            for (int i = 0; i < NumberOfItems; i++)
            {
                SortList.Add(i, ("Hello World!" + i));
            }
            return SortList;
        }

        [Benchmark]
        public IDictionary ConcatStringsUsingDictionary()
        {
            var Dictionary = new Dictionary<int,string>();

            for (int i = 0; i < NumberOfItems; i++)
            {
                Dictionary.Add(i, ("Hello World!" + i));
            }
            return Dictionary;
        }
        [Benchmark]
        public ArrayList ConcatStringsUsingArrayList()
        {
            var ArrayList = new ArrayList();

            for (int i = 0; i < NumberOfItems; i++)
            {
                ArrayList.Add(i);
            }
            return ArrayList;
        }

        [Benchmark]
        public int[] ConcatStringsUsingArray()
        {
            var Array = new int[NumberOfItems];

            for (int i = 0; i < NumberOfItems; i++)
            {
                Array[i] =  i;
            }
            return Array;
        }

        [Benchmark]
        public string ConcatStringsUsingStringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < NumberOfItems; i++)
            {
                sb.Append("Hello World!" + i);
            }
            return sb.ToString();
        }
        [Benchmark]
        public string ConcatStringsUsingGenericList()
        {
            var list = new List<string>(NumberOfItems);
            for (int i = 0; i < NumberOfItems; i++)
            {
                list.Add("Hello World!" + i);
            }
            return list.ToString();
        }
    }
}
