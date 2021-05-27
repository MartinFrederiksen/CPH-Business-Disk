using System.Collections.Generic;

namespace Exercise.wgraph
{
    public interface IGraph
    {
        int v();
        int e();
        IEnumerator<IEdge> adjacents(int vertex);
        IEnumerator<IEdge> edges();
    }
}