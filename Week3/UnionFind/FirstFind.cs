using System;

namespace Week3.UnionFind
{
    public class FirstFind : IUnionFind
    {
        private int[] ids;
        private int counter;

        public FirstFind(int size)
        {
            ids = new int[size];
            counter = size;
            for (int i = 0; i < size; i++) ids[i] = i;
        }

        /*
        --->  0  1  2  3  4  5  6  7  8  9
        ids: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
        count: 10

        union(1, 7)
        --->  0  1  2  3  4  5  6  7  8  9
        ids: [0, 1, 2, 3, 4, 5, 6, 1, 8, 9]
        count: 9

        union(8, 7)
        --->  0  1  2  3  4  5  6  7  8  9++
        ids: [0, 8, 2, 3, 4, 5, 6, 8, 8, 9]
        count: 8
        */
        public int count()
        {
            return counter;
        }

        public int find(int p)
        {
            return ids[p];
        }

        public void union(int p, int q)
        {
            if (((IUnionFind)this).connected(p, q)) return;
            int idQ = ids[q];  // 1
            int idP = ids[p];  // 8
            for (int i = 0; i < ids.Length; i++) {
                if (ids[i] == idQ) ids[i] = idP;
            }
            counter--;
        }
        public void print() {
            foreach (var item in ids)
            {
                Console.WriteLine(item);
            }
        }
    }
}