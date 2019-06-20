using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class LevelOrderTreeTraversal
    {
        public LevelOrderTreeTraversal()
        {
            Node node = new Node() { Value = 1 };
            node.Left = new Node() { Value = 2 };
            node.Right = new Node() { Value = 3 };

            node.Left.Left = new Node() { Value = 4 };
            node.Left.Right = new Node() { Value = 5 };

            PrintLevelOrderTraversal(node);
        }

        public void PrintLevelOrderTraversal(Node node)
        {
            int height = Height(node);

            for (int i = 1; i <= height; i++)
            {
                PrintGivenLevel(node, i);
            }
        }

        public void PrintGivenLevel(Node node, int level)
        {
            if(node == null)
            {
                return;
            }
            else if(level == 1)
            {
                Console.WriteLine(node.Value);
            }
            else if(level > 1)
            {
                PrintGivenLevel(node.Left, level - 1);
                PrintGivenLevel(node.Right, level - 1);
            }
        }

        private int Height(Node root)
        {
            if(root == null)
            {
                return 0;
            }

            return Math.Max(Height(root.Left), Height(root.Right)) + 1;
        }
    }
}
