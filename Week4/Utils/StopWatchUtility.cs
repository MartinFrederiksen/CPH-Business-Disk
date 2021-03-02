using System;
using System.Diagnostics;

namespace Week4.Utils
{
    public class StopWatchUtility
    {
        public static readonly Stopwatch watch = new Stopwatch();
        public T stopWatch<T>(Func<T> sort)
        {
            watch.Start();
            T timed = sort();
            watch.Stop();
            Console.Write("Time elapsed: " + watch.Elapsed + "\n");
            watch.Reset();
            return timed;
        }
    }
}