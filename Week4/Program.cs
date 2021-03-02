using System;
using Week4.Sorting;
using Week4.Utils;
using System.Linq;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = 2500;
            string[] unsorted = FileUtility.toStringArray("./Data/shakespeareCompleteWorks.txt", lines);

            Console.Write("-----Sorted with insertion-----\n");
            string[] insertionSorted = new StopWatchUtility().stopWatch(() => new InsertionSort<string>((string[])unsorted.Clone()).sort());
            //ISort<string>.print(insertionSorted);

            Console.Write("-----Sorted with selection-----\n");
            string[] selectionSorted = new StopWatchUtility().stopWatch(() => new SelectionSort<string>((string[])unsorted.Clone()).sort());
            //ISort<string>.print(selectionSorted);

            Console.Write("-----Sorted with merge-----\n");
            string[] mergeSorted = new StopWatchUtility().stopWatch(() => new MergeSort<string>((string[])unsorted.Clone()).sort());
            //ISort<string>.print(mergeSorted);

            Console.Write("-----Sorted with quick-----\n");
            string[] quickSorted = new StopWatchUtility().stopWatch(() => new QuickSort<string>((string[])unsorted.Clone()).sort());
            //ISort<string>.print(quickSorted);

            Console.Write("-----Sorted with heap-----\n");
            string[] heapSort = new StopWatchUtility().stopWatch(() => new HeapSort<string>((string[])unsorted.Clone()).sort());
            //ISort<string>.print(heapSort);

            Console.Write("-----Sorted with trie-----\n");
            string[] trieOutput = new StopWatchUtility().stopWatch<string[]>(() => new TrieSort((string[])unsorted.Clone()).sort());
            //ISort<string>.print(trieOutput);

        }
    }
}
