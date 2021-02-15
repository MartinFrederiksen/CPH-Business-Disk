using System;
using Week3.UnionFind;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickUnion qu = new QuickUnion(10);
            //-------First Set-------
            qu.union(9, 8);
            qu.union(4, 3);
            qu.union(3, 8);
            //-------First Set-------
            qu.union(7, 1);
            qu.union(2, 1);
            qu.union(6, 5);
            qu.union(5, 0);
            qu.union(0, 1);
            //-------Combined Set-------
            qu.union(5, 9);
            Console.WriteLine("------Quick Union------");
            qu.print();

            WeightedQuickUnion wqu = new WeightedQuickUnion(10);
            //-------First Set-------
            wqu.union(9, 8);
            wqu.union(4, 3);
            wqu.union(3, 8);
            //-------First Set-------
            wqu.union(7, 1);
            wqu.union(2, 1);
            wqu.union(6, 5);
            wqu.union(5, 0);
            wqu.union(0, 1);
            //-------Combined Set-------
            wqu.union(5, 9);
            Console.WriteLine("------Weighted Quick Union------");
            wqu.print();
        }
    }
}
