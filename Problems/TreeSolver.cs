
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Problems
{
    public class TreeSolver
    {
        public static string Solve(string fileName)
        {
            Node root = null;
            Node[] prevNodes = null;

            using (Stream stream = Assembly.GetExecutingAssembly()
                                           .GetManifestResourceStream("Problems." + fileName))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    string result = reader.ReadLine();
                    string[] parts = result.Split(' ');

                    Node[] nodes = parts.Select(p => new Node(Convert.ToInt64(p))).ToArray();
                    if (prevNodes == null)
                    {
                        root = nodes.Single();
                    }
                    else
                    {
                        for (int i = 0; i < prevNodes.Length; i++)
                        {
                            // If leftmost then.
                            prevNodes[i].Left = nodes[i];
                            prevNodes[i].Right = nodes[i + 1];
                        }
                    }

                    prevNodes = nodes;
                }
            }

            Traverse(root, 0);

            long max = prevNodes.Max(x => x.Total);
            return max.ToString();
        }

        private static void Traverse(Node node, long max)
        {
            if (node == null)
                return;

            if (node.MaxToGetHere < max)
            {
                node.MaxToGetHere = max;
            }
            else if (node.Visited)
            {
                return;
            }

            node.Visited = true;

            Traverse(node.Left, node.Data + node.MaxToGetHere);
            Traverse(node.Right, node.Data + node.MaxToGetHere);
        }
         
    }
}