using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class MaxDepthOfTree
    {
        public MaxDepthOfTree()
        {
            Node node = new Node() { Value = 1 };
            node.Left = new Node() { Value = 2 };
            node.Right = new Node() { Value = 3 };

            node.Left.Left = new Node() { Value = 4 };
            node.Left.Right = new Node() { Value = 5 };

            Console.WriteLine(MaxDepth(node));
        }

        private int MaxDepth(Node node)
        {
            int maxDepth = 0;

            if (node == null)
            {
                return 0;
            }
            else
            {
                maxDepth += Math.Max(MaxDepth(node.Left), MaxDepth(node.Right));
                maxDepth++;
            }

            return maxDepth;
        }

    }

    public class Node
    {
        public Node Left { get; set; }
        public int Value { get; set; }
        public Node Right { get; set; }
    }
}
