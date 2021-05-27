using System.Collections.Generic;
using System.IO;
using Exercise.wgraph.builder;

namespace Exercise.wgraph.impl
{
    public class GraphFactoryImpl : IGraphFactory
    {
        public IGraphBuilder getNewBuilder(int verticeCount)
        {
            return new GraphImpl(verticeCount);
        }

        public IGraph readFromFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            int verticeCount = int.Parse(lines[0]);
            IGraphBuilder builder = getNewBuilder(verticeCount);
            int edgeCount = int.Parse(lines[1]);
            for(int i = 2; i < edgeCount+2; i++)
            {
                string line = lines[i];
                string[] vs = line.Split(" ");
                int vertex1 = int.Parse(vs[0]);
                int vertex2 = int.Parse(vs[1]);
                float weight = float.Parse(vs[2]);
                builder.addEdge(vertex1, vertex2, weight);
            }
            return builder.build();
        }
    }
}