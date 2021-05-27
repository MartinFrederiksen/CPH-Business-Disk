using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class PriorityQueue : IUtility
    {
        private List<int> pQ;
        int peekCounter;
        public PriorityQueue()
        {
            pQ = new List<int>();
            peekCounter = 0;
        }

        public void add(int vertex)
        {
            pQ.Add(vertex);
            peekCounter = 0;
        }

        public void pop()
        {
            pQ.Remove(pQ.Max());
            peekCounter = 0;
        }
        
        public int peek()
        {
            return pQ.Max() - peekCounter++;
        }
    }
}