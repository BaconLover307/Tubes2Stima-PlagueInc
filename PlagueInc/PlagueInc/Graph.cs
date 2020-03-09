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
        // Graph representation using adjacency list of <dest node, tr>
        private Dictionary<string, List<Tuple<string, double>>> graph;
        private Dictionary<string, int> population;
        private Dictionary<string, int> timeInfected; // time first affected
        private Dictionary<string, string> edgeInfected;
        private int inputTime;
        private string viralSource; // first affected city

        // Constructor
        public Graph()
        {
            graph = new Dictionary<string, List<Tuple<string, double>>>();
            population = new Dictionary<string, int>();
            timeInfected = new Dictionary<string, int>();
            edgeInfected = new Dictionary<string, string>();
            inputTime = 0;
            viralSource = "#";
        }
  
        // Graph method
        public void addNode(string node)
        {
            graph[node] = new List<Tuple<string, double>>();
            population[node] = 0; // default value
            timeInfected[node] = int.MaxValue; // default value
        }
        public void addEdge(string src, string dst, double tr)
        {
            // Check if node not exist
            if (!graph.ContainsKey(src))
                addNode(src);
            if (!graph.ContainsKey(dst))
                addNode(dst);
            // Add directed edge
            graph[src].Add(new Tuple<string, double>(dst, tr));
        }
        public void BFS(string src)
        {
            // Init
            Queue<Tuple<string,string>> q = new Queue<Tuple<string,string>>();

            // Set timeInfected with src key to 0
            timeInfected[src] = 0;

            // Add to Q neighbour(s) of src
            foreach (var adjNode in graph[src])
            {
                q.Enqueue(new Tuple<string, string>(src, adjNode.Item1));
            }

            // BFS
            while (q.Count != 0)
            {
                string srcN = q.Dequeue().Item1;
                string dstN = q.Dequeue().Item2;

                if (S(srcN, dstN) > 1.0)
                {
                    // add srcN -> dstN to edgeInfected
                    edgeInfected[srcN] = dstN;

                    double t = Math.Ceiling(1 / S(srcN, dstN));
                    int time = (int)t;

                    if (timeInfected[srcN] + time <= timeInfected[dstN])
                    {
                        timeInfected[dstN] = timeInfected[srcN] + time;
                        foreach (var adjNode in graph[dstN]) // Add to Q neighbour(s) of dstN
                        {
                            q.Enqueue(new Tuple<string, string>(src, adjNode.Item1));
                        }
                    }
                    else
                    {
                        timeInfected[dstN] = timeInfected[srcN] + time;
                    }
                }
            }
        }

        // Getter and setter
        public Dictionary<string, List<Tuple<string, double>>> getGraph()
        {
            return graph;
        }
        public Dictionary<string, int> getTimeInfected()
        {
            return timeInfected;
        }
        public void setPopulation(string node, int num)
        {
            population[node] = num;
        }
        public void setInputTime(int time)
        {
            inputTime = time;
        }
        public void setViralSource(string src)
        {
            viralSource = src;
        }

        // Corona method
        private double P(string A)
        {
            return Convert.ToDouble(population[A]);
        }
        public int t(string A)
        // Return max time since affected
        {
            return Math.Max(0, inputTime - timeInfected[A]);
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
            // Viral source
            result += String.Format("Viral source : {0}\n", viralSource);
            // Max time since affected
            result += "Max time since affected:\n";
            foreach (var src in timeInfected)
            {
                result += String.Format("{0} : {1}\n", src.Key, t(src.Key));
            }
            return result;
        }
    }
}
