using System;

namespace Week4.Sorting
{
    public class MergeSort<T> : ISort<T> where T : IComparable
    {
        T[] arr;
        public MergeSort(T[] arr)
        {
            this.arr = arr;
        }

        private void merge(int left, int middle, int right) {
            int leftLength = middle - left + 1, rightLength = right - middle;
            T[] temp = (T[])arr.Clone();
            int i = 0, j = 0, k = left;

            while (i < leftLength && j < rightLength) {
            if (temp[left + i].CompareTo(temp[middle + 1 + j]) <= 0) {
                arr[k++] = temp[left + i++];
            }
            else {
                arr[k++] = temp[middle + 1 + j++];
            }
        }

        while (i < leftLength) {
            arr[k++] =temp[left + i++];
        }
    
        while (j < rightLength) {
            arr[k++] = temp[middle + 1 + j++];
        }

        }
        private void sort(int left, int right) {
            if(left < right) {
                int middle = (left + (right - 1)) / 2;

            sort(left, middle);
            sort(middle + 1, right);
            
            merge(left, middle, right);
            }
        }

        public T[] sort()
        {
            sort(0, arr.Length-1);
            return arr;
        }
    }
}