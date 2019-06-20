using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class TreeInOrderPreOrderPostOrder
    {
        public TreeInOrderPreOrderPostOrder()
        {
            Node node = new Node() { Value = 1 };
            node.Left = new Node() { Value = 2 };
            node.Right = new Node() { Value = 3 };

            node.Left.Left = new Node() { Value = 4 };
            node.Left.Right = new Node() { Value = 5 };

            TreeTraversal(node);
        }

        public void TreeTraversal(Node tree)
        {
            if(tree == null)
            {
                return;
            }
            Console.WriteLine("InOrder");
            TreeTraversal(tree.Left);
            Console.WriteLine(tree.Value);
            TreeTraversal(tree.Right);
        }
    }
}
