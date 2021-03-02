using System;
using System.Linq;

namespace Week4.Sorting
{
    public interface ISort<T>
    {
        T[] sort();

        static void print(T[] arr, int max = -1)
        {
            Console.WriteLine(String.Join(", ", arr.Take(max >= 0 ? max : arr.Length)));
        }
    }
}