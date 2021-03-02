using System;

namespace Week4.Sorting
{
    public class InsertionSort<T> : ISort<T> where T : IComparable
    {
        T[] unsorted;
        public InsertionSort(T[] arr)
        {
            this.unsorted = arr;
        }

        public T[] sort() 
        {
            T elementToSort;
            for(int i = 1; i < unsorted.Length; i++) 
            {
                elementToSort = unsorted[i];
                int j = i - 1;
                
                while(j >= 0 && (unsorted[j].CompareTo(elementToSort) >= 1))
                {
                    unsorted[j+1] = unsorted[j--];
                }
                unsorted[j+1] = elementToSort;
            }
            return unsorted;
        }
    }
}