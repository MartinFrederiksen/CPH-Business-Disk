using System;
using Week4.Utils;

namespace Week4.Sorting
{
    public class QuickSort<T> : ISort<T> where T : IComparable
    {
        T[] unsorted;
        public QuickSort(T[] arr)
        {
            this.unsorted = arr;
        }

        public T[] sort() {
            sort(unsorted, 0, unsorted.Length - 1);
            return unsorted;
        }
        public T[] sort(T[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = partiion(arr, low, high);

                sort(arr, low, pi - 1);
                sort(arr, pi + 1, high);
            }
            return arr;
        }

        private int partiion(T[] arr, int low, int high)
        {
            T pivot = arr[high];
            int i = (low - 1);

            for(int j = low; j <= high - 1; j++)
            {
                if(arr[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    SwapUtility.swap(i, j, arr);
                }
            }
            SwapUtility.swap(i + 1, high, arr);
            return (i + 1);
        }
    }

}