using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercise.wgraph.builder;

namespace Exercise.wgraph.impl
{
    public class GraphImpl : IGraph, IGraphBuilder
    {
        private List<IEdge> emptyList = new List<IEdge>(0);
        private List<IEdge>[] array;
        private List<IEdge> allEdges;

        public GraphImpl(int verticeCount)
        {
            this.array = new List<IEdge>[verticeCount];
            this.allEdges = new List<IEdge>();
        }

        public int e()
        {
            return allEdges.Count();
        }

        public int v()
        {
            return array.Length;
        }

        public IEnumerator<IEdge> adjacents(int vertex)
        {
            List<IEdge> list = array[vertex];
            if(list == null)
            {
                return emptyList.GetEnumerator();
            }
            return list.GetEnumerator();
        }
        
        public IEnumerator<IEdge> edges()
        {
            return allEdges.GetEnumerator();
        }

        public void addEdge(int vertex1, int vertex2, float weight)
        {
            IEdge e = new EdgeImpl(vertex1, vertex2, weight);
            allEdges.Add(e);
            addEdgeToList(vertex1, e);
            addEdgeToList(vertex2, e);
        }

        private void addEdgeToList(int vertex, IEdge e)
        {
            List<IEdge> list = array[vertex];
            if(list == null)
            {
                list = new List<IEdge>();
                array[vertex] = list;
            }
            list.Add(e);
        }

        public IGraph build()
        {
            return this;
        }

        public override string ToString()
        {
            string res1 = String.Join(Environment.NewLine,
                v(),
                e());
            string res2 = String.Join(Environment.NewLine,
                allEdges.Select(edge => $"{edge.getEither()} {edge.getOther(edge.getEither())} {edge.getWeight()}").ToArray());
            return $"{res1}\n{res2}";
        }
    }
}