using Exercise.wgraph.builder;

namespace Exercise.wgraph
{
    public interface IGraphFactory
    {
        IGraphBuilder getNewBuilder(int verticeCount);
        IGraph readFromFile(string filename);
    }
}