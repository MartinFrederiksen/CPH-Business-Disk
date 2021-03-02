using System;
using Week4.Utils;

namespace Week4.Sorting
{
    public class SelectionSort<T> : ISort<T> where T : IComparable
    {
        T[] unsorted;
        public SelectionSort(T[] arr)
        {
            this.unsorted = arr;
        }

        public T[] sort() 
        {
            for(int i = 0; i < unsorted.Length; i++) 
            {
                int index = i;
                for(int j = i+1; j < unsorted.Length; j++)
                {
                    if(unsorted[j].CompareTo(unsorted[index]) < 1) index = j;

                }
                SwapUtility.swap(i, index, unsorted);
            }
            return unsorted;
        }
    }
}