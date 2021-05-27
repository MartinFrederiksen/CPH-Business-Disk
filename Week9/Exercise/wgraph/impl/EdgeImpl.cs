using System;

namespace Exercise
{
    public class EdgeImpl : IEdge
    {
        private int vertex1;
        public int vertex2;
        private float weight;

        public EdgeImpl(int vertex1, int vertex2, float weight)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.weight = weight;
        }

        public int compareTo(IEdge o)
        {
            //this.compareTo(other) < 0: if this < other
            //this.compareTo(other) = 0: if this == other
            //this.compareTo(other) > 0: if this > other
            float f = this.weight - o.getWeight();
            if(f > 0) return 1;
            if(f < 0) return -1;
            return 0;
        }

        public int getEither()
        {
            return vertex1;
        }

        public float getWeight()
        {
            return weight;
        }

        public int getOther(int vertex)
        {
            if(vertex == vertex1)
            {
                return vertex2;
            }
            if(vertex == vertex2)
            {
                return vertex1;
            }
            throw new ArgumentException(vertex + " is not a vertex in " + this);
        }
    }
}