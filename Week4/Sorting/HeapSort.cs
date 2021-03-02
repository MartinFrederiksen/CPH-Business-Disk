using System;
using Week4.Utils;

namespace Week4.Sorting
{
    public class HeapSort<T> : ISort<T> where T : IComparable
    {
        T[] unsorted;
        public HeapSort(T[] arr)
        {
            this.unsorted = arr;
        }

        public T[] sort()
        {
            int size = unsorted.Length;
            for(int i = size / 2 - 1; i >= 0; i--)
                heapify(size, i);

            for (int i = size - 1; i >= 0; i--) {
                SwapUtility.swap<T>(0, i, unsorted);

                heapify(i, 0);
            }

            return unsorted;
        }

        private void heapify(int n, int i)
        {
            int lowest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if(left < n && unsorted[left].CompareTo(unsorted[lowest]) < 1)
                lowest = left;

            if(right < n && unsorted[right].CompareTo(unsorted[lowest]) < 1)
                lowest = right;

            if(lowest != i) {
                SwapUtility.swap<T>(i, lowest, unsorted);
                heapify(n, lowest);
            }
        }
    }
}