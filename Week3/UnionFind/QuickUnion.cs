using System;
namespace Week3.UnionFind
{
    public class QuickUnion : IUnionFind
    {
        private int[] parents;
        private int counter;

        public QuickUnion(int size)
        {
            counter = size;
            parents = new int[size];
            for(int i = 0; i < size; i++) parents[i] = i;
        }

        public int count()
        {
            return counter;
        }

        public int find(int p)
        {
            while(p != parents[p])
                p = parents[p];
            return p;
        }

        public void union(int p, int q)
        {
            int rootP = find(p);
            int rootQ = find(q);
            if (rootP == rootQ) return;
            parents[rootP] = rootQ;
            counter--;
        }

        public void print() {
            foreach (var item in parents)
            {
                Console.WriteLine(item);
            }
        }
    }
}