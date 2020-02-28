using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagueInc
{
    class Graph
    // Directed graph implementation
    {
        // Graph representation using adjacency list of <dest node, weight>
        private Dictionary<string, List<Tuple<string, double>>> map;
        
        // Constructor
        public Graph()
        {
            map = new Dictionary<string, List<Tuple<string, double>>>();
        }
  
        // Graph method
        public void addNode(string node)
        {
            map[node] = new List<Tuple<string, double>>();
        }
        public void addEdge(string src, string dst, double weight)
        {
            // Check if node not exist
            if (!map.ContainsKey(src))
                addNode(src);
            if (!map.ContainsKey(dst))
                addNode(dst);
            // Add directed edge
            map[src].Add(new Tuple<string, double>(dst, weight));
        }
        public void BFS(string src)
        {
            // Init
            Queue<string> q = new Queue<string>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (var node in map)
                visited[node.Key] = false;
            // Src
            q.Enqueue(src);
            visited[src] = true;
            // BFS
            while (q.Count != 0)
            {
                string actNode = q.Dequeue();
                System.Console.WriteLine(actNode);
                // Iterate over neighbour
                foreach (var adjNode in map[actNode])
                {
                    if (!visited[adjNode.Item1])
                    {
                        q.Enqueue(adjNode.Item1);
                        visited[adjNode.Item1] = true;
                    }
                }
            }
        }

        // Utils
        public override string ToString()
        {
            var result = "Adjacency list:\n";
            foreach (var src in map)
            {
                result += String.Format("{0}", src.Key);
                foreach (var dst in src.Value)
                {
                    result += String.Format(" --> {0}[{1}]", dst.Item1, dst.Item2);
                }
                result += "\n";
            }
            return result;
        }
    }
}
