namespace Week3.UnionFind
{
    public interface IUnionFind
    {
        void union(int p, int q);        // unite points p and q
        int find(int p);                 // given point p retun set of p
        bool connected(int p, int q) {   // are the points p and q in the same set
            return find(p) == find(q);
        }
        int count();                     // how many sets are there
    }
}