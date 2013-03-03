using System.Collections.Generic;

namespace Problems
{
    //public delegate void TreeVisitor<T>(T nodeData);

    public class Node
    {
        public Node(long data)
        {
            Data = data;
        }

        public long Total
        {
            get { return MaxToGetHere + Data; }
        }

        public bool Visited { get; set; }

        public long MaxToGetHere { get; set; }
        public long Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}