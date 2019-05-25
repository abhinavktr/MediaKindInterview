using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinaryTree
    {
       public Node root;

       public List<int> list = new List<int>();
       public void inorder(Node node)
        {
            if (node == null)
                return;
            inorder(node.left);
            list.Add(node.value);
            inorder(node.right);
        }

        public void preorder(Node node)
        {
            if (node == null)
                return;
            list.Add(node.value);
            preorder(node.left);
            preorder(node.right);
        }

        public void postorder(Node node)
        {
            if (node == null)
                return;
            postorder(node.left);
            postorder(node.right);
            list.Add(node.value);
        }

        //preorder traversal approach
        public Node MergeTree(Node firstRoot,Node secondRoot)
        {
            if (firstRoot == null)
                return secondRoot;
            if (secondRoot == null)
                return firstRoot;
            firstRoot.value += secondRoot.value;
            list.Add(firstRoot.value);
            firstRoot.left = MergeTree(firstRoot.left, secondRoot.left);
            firstRoot.right = MergeTree(firstRoot.right, secondRoot.right);
            return firstRoot;
        }
    }

    public class Node
    {
       public int value;
       public Node left;
       public Node right;
        public Node(int item)
        {
            value = item;
            left = right = null;
        }
    }
}
