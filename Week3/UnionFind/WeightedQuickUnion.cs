using System;
namespace Week3.UnionFind
{
    public class WeightedQuickUnion : IUnionFind
    {
        int[] parents;
        int[] value;
        int counter;
        public WeightedQuickUnion(int size)
        {
            counter = size;
            parents = new int[size];
            value = new int[size];
            for(int i = 0; i < size; i++) {
                parents[i] = i;
                value[i] = 1;
            }
        }

        public int count()
        {
            return counter;
        }

        public int find(int p)
        {
            while (p != parents[p])
                p = parents[p];
            return p;
        }

        public void union(int p, int q)
        {
            int rootP = find(p);
            int rootQ = find(q);
            if (rootP == rootQ) return;

            if (value[rootP] < value[rootQ]) {
                parents[rootP] = rootQ;
                value[rootQ] += value[rootP];
            }
            else {
                parents[rootQ] = rootP;
                value[rootP] += value[rootQ];
            }
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