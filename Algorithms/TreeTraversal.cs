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

        public static int HeightOfTree(Node root)
        {
            if (root == null) return 0;
            return Math.Max(HeightOfTree(root.left), HeightOfTree(root.right)) + 1;
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
            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();
            stack1.Push(root);
            while(stack1.Count > 0)
            {
                var temp = stack1.Pop();
                if (temp.right != null) stack1.Push(temp.right);
                if (temp.left != null) stack1.Push(temp.left);
            }
            while(stack2.Count > 0)
            {
                resultsList.Add(stack2.Pop().value);
            }
        }

        public int MaxDepthOfTree(Node root)
        {
            if (root == null) return 0;
            return Math.Max(MaxDepthOfTree(root.left), MaxDepthOfTree(root.right)) + 1;
        }

        public int FindLeastCommonAncestor(Node root,int n1,int n2)
        {
         List<int> _recorder1 = new List<int>();
         List<int> _recorder2 = new List<int>();
            //https://www.geeksforgeeks.org/lowest-common-ancestor-binary-tree-set-1/
            findElementAndRecordPath(root, n1, _recorder1);
         findElementAndRecordPath(root, n2, _recorder2);
            return 1;
        }

        public Node FindLeastCommonAncestorUsingSingleTraversal(Node root, int n1, int n2)
        {
            if (root == null) return null;
            if (root.value == n1 || root.value == n2)
                return root;
            Node leftTraversal = FindLeastCommonAncestorUsingSingleTraversal(root.left, n1, n2);
            Node rightTraversal = FindLeastCommonAncestorUsingSingleTraversal(root.right, n1, n2);
            if (leftTraversal != null && rightTraversal != null)
                return root;
            return leftTraversal ?? rightTraversal;
        }
            public bool findElementAndRecordPath(Node root, int v1, List<int> recorder)
        {
            if (root == null) return false;
            recorder.Add(root.value);
            if (root.value == v1)
            {
                return true;
            }
            if (root.left != null && findElementAndRecordPath(root.left, v1, recorder)) return true;
            if (root.right != null && findElementAndRecordPath(root.right, v1, recorder)) return true;
            recorder.Remove(root.value);
            return false;
        }

        public override bool Equals(object obj) => obj is TreeTraversal traversal &&
                   EqualityComparer<List<int>>.Default.Equals(resultsList, traversal.resultsList);

        public override int GetHashCode() => -2114097543 + EqualityComparer<List<int>>.Default.GetHashCode(resultsList);
    }
}
