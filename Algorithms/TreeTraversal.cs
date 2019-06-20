using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class TreeTraversal
    {
        private List<int> resultsList = new List<int>();
        public void PreOrderIterative(Node root)
        {
            resultsList.Clear();
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                Node temp = stack.Pop();
                resultsList.Add(temp.value);
                //push the right first as we need to iterate left subtree first
                if (temp.right != null)
                    stack.Push(temp.right);
                //push the left
                if (temp.left != null)
                    stack.Push(temp.left);

            }
        }
        public void PreOrderRecursive(Node root)
        {
            if (root == null)
                return;
            resultsList.Add(root.value);
            PreOrderRecursive(root.left);
            PreOrderRecursive(root.right);
        }

        public void InOrderIterative(Node root)
        {
            Node current = root;
            Stack<Node> stack = new Stack<Node>();
            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                current = stack.Pop();
                resultsList.Add(current.value);
                if (current != null && current.right != null) current = current.right;
                else current = null;
            }
        }

        public void InOrderRecursive(Node root)
        {
            if (root == null)
                return;
            InOrderRecursive(root.left);
            resultsList.Add(root.value);
            InOrderRecursive(root.right);
        }

        public void PostOrderRecursive(Node root)
        {
            if (root == null)
                return;
            PostOrderRecursive(root.left);
            PostOrderRecursive(root.right);
            resultsList.Add(root.value);
        }

        public void PostOrderIterative(Node root)
        {
        }
    }
}
