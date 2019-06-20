using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class BinaryTreeMerge
    {
        public BinaryTreeMerge() 
        {
            TreeNode testNode = new TreeNode(10);
            testNode.left = new TreeNode(9);
            TreeNode testNode1 = new TreeNode(20);
            testNode1.left = new TreeNode(19);
            testNode1.right = new TreeNode(21);

            TreeNode result = MergeTrees(testNode, testNode1);


            Console.WriteLine(result.val);
        }

        // The merge rule is that if two nodes overlap, 
        // then sum node values up as the new value of the merged node. 
        // Otherwise, the NOT null node will be used as the node of new tree.
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null || t2 == null)
            {
                return t1 ?? t2;
            }
            else
            {
                TreeNode mergedLeftNode = MergeTrees(t1.left, t2.left);
                TreeNode mergedRightNode = MergeTrees(t1.right, t2.right);
                return new TreeNode(t1.val + t2.val)
                {
                    left = mergedLeftNode,
                    right = mergedRightNode
                };
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    //    1                        2                     3
    //  10 20         +          30 40         =       40 60
    // 100                                           100   
}
