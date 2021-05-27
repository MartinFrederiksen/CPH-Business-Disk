using System;
using Exercise.wgraph.impl;

namespace Exercise.wgraph
{
    class Program
    {
        static void Main(string[] args)
        {
            IGraphFactory factory = new GraphFactoryImpl();
            IGraph myGraph = factory.readFromFile("./Problems/GraphTest");
            Console.WriteLine(myGraph.ToString());
            
            //Console.WriteLine(gii.toString());
            // IEnumerator emm = gii.adjacents(0);
            // while(emm.MoveNext())
            // {
            //     Console.WriteLine(emm.Current);
            // // }
            AStar.Run("./Problems/ProblemA.txt");
            AStar.Run("./Problems/ProblemB.txt");
            AStar.Run("./Problems/ProblemC.txt");
        }
    }
}
