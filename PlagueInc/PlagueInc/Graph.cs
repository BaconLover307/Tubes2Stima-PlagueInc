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
        private Dictionary<string, List<Tuple<string, double>>> graph;
        private Dictionary<string, int> population;
        private Dictionary<string, int> time; // time first affected
        private int timeNow;

        // Constructor
        public Graph()
        {
            graph = new Dictionary<string, List<Tuple<string, double>>>();
            population = new Dictionary<string, int>();
            time = new Dictionary<string, int>();
            timeNow = 0;
        }
  
        // Graph method
        public void addNode(string node)
        {
            graph[node] = new List<Tuple<string, double>>();
            population[node] = 0; // default value
            time[node] = int.MaxValue; // default value
        }
        public void setPopulation(string node, int num)
        {
            population[node] = num;
        }
        public void addEdge(string src, string dst, double weight)
        {
            // Check if node not exist
            if (!graph.ContainsKey(src))
                addNode(src);
            if (!graph.ContainsKey(dst))
                addNode(dst);
            // Add directed edge
            graph[src].Add(new Tuple<string, double>(dst, weight));
        }
        public void BFS(string src)
        {
            // Init
            Queue<string> q = new Queue<string>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (var node in graph)
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
                foreach (var adjNode in graph[actNode])
                {
                    if (!visited[adjNode.Item1])
                    {
                        q.Enqueue(adjNode.Item1);
                        visited[adjNode.Item1] = true;
                    }
                }
            }
        }

        // Corona method
        private double P(string A)
        {
            return Convert.ToDouble(population[A]);
        }
        public int t(string A)
        // Return time since affected
        {
            return Math.Max(0, timeNow - time[A]);
        }
        public double I(string A, int t)
        {
            double e = Math.E;
            double gamma = 0.25;
            double denum = 1 + (P(A) - 1) * Math.Pow(e, -gamma * t);
            return (P(A) / denum);
        }
        public double Tr(string A, string B)
        // Precondition: A != B
        {
            foreach (var adj in graph[A])
                if (adj.Item1 == B)
                    return adj.Item2;
            // not found
            return 0;
        }
        public double S(string A, string B)
        {
            return (I(A, t(A)) * Tr(A, B));
        }

        // Utils
        public override string ToString()
        {
            // Adjacency list
            var result = "Adjacency list:\n";
            foreach (var src in graph)
            {
                result += String.Format("{0}", src.Key);
                foreach (var dst in src.Value)
                {
                    result += String.Format(" --> {0}[{1}]", dst.Item1, dst.Item2);
                }
                result += "\n";
            }
            // Population
            result += "Population:\n";
            foreach(var src in population)
            {
                result += String.Format("{0} : {1}\n", src.Key, src.Value);
            }
            // Time since affected
            result += "Time since affected:\n";
            foreach (var src in time)
            {
                result += String.Format("{0} : {1}\n", src.Key, t(src.Key));
            }
            return result;
        }
    }
}
