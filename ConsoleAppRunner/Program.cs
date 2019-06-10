using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Trees();
        }

        private static void RainDropTrap()
        {
            int volume = RainningDropsCollection.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
        }

        private static void HashSet()
        {
            var hashSet = new Algorithms.HashSet<int>(8);
            hashSet.Add(3);
            hashSet.Add(5);
            hashSet.Add(6);

            var hashSet1 = new Algorithms.HashSet<string>(8);
            hashSet1.Add("abhi");
            hashSet1.Add("nav");
            hashSet1.Add("ibha");
        }

        private static void Trees()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

           LevelSumTrees.LevelSum(tree.root);
           var size = BinaryTree.TreeSize1(tree.root);

            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Node(2);
            tree2.root.left = new Node(4);
            tree2.root.left.right = new Node(6);
            tree2.root.right = new Node(5);
            tree2.root.right.left = new Node(8);
            tree2.root.right.right = new Node(9);

            var result = new BinaryTree();
            //result.inorder(tree.root);
            //result.preorder(tree.root);
            //result.postorder(tree.root);
            result.MergeTree(tree.root, tree2.root);
        }

        private static void MergeTwoSortedArray()
        {
            int[] ar1 = new int[4] { 2, 4, 20, 90 };
            int[] ar2 = new int[5] { 1, 3, 5, 6, 10 };
            MergeArrays mergeArrays = new MergeArrays();
            mergeArrays.Merge(ar1, ar2);
        }

        private static void Sudoku()
        {
            int[,] sudoku_data_valid = new int[,]
                        {
                {5, 3, 4, 6, 7, 8, 9, 1, 2 },
                { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                { 1, 9, 8, 3, 4, 2, 5, 6, 7},
                { 8, 5, 9, 0, 6, 1, 4, 2, 3 },
                { 4, 2, 6, 8, 5, 3, 0, 9, 1 },
                { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                { 3, 4, 5, 0, 8, 6, 1, 0, 0 }
                        };
            Sudoku sudoku = new Sudoku();
            var result = sudoku.Validate(sudoku_data_valid);
            var result1 = sudoku.Solve(sudoku_data_valid);
        }
    }
}
