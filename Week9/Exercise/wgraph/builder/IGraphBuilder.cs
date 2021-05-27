namespace Exercise.wgraph.builder
{
    public interface IGraphBuilder
    {
        void addEdge(int vertex1, int vertex2, float weight);
        IGraph build();
    }
}