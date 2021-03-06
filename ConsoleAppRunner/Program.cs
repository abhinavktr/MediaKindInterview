﻿using Algorithms;
using DOTNETBASICS;
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
            //Console.WriteLine("Please enter string for permutation:");
            string input = "ABC";
            //Console.ReadLine();

           // functPermut("ABC");

            //String str = "ABC";
            //int n = str.Length;
            //permute(str, 0, n - 1);

            int value = factorial(5);
            //5 * 4 * 3 * 2

        }

        private static int factorial(int number)
        {
            if (number <= 1) return number;

            return number * factorial(number - 1);
        }

      
        static List<string> strOutput = new List<string>();
        public  static string functPermut(string input)
        {
            int length = input.Length;
            if (length == 0) return ""; // empty, no more char available
            if (length == 1) return input; // if a single char no need to permutate further

            for (int i = 0; i < length - 1; i++)
            {
                char current = input[i];
                string remainingLetter = input.Substring(i + 1, length - 1);
                for (int j = 0; j < remainingLetter.Length - 1; j++)
                {
                    strOutput.Add(current + functPermut(remainingLetter));
                }
            }

            return input;
        }




        
     

       
    

    // This code is contributed by mits




















    private static void TreeTraversaltest()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);


            TreeTraversal treeTraversal = new TreeTraversal();
            treeTraversal.FindLeastCommonAncestor(tree.root, 5, 4);
            treeTraversal.InOrderIterative(tree.root);
            treeTraversal.InOrderRecursive(tree.root);
        }

        public static void ConvertNumberToBinary(int n)
        {
            while(n > 0)
            {
                var v = n % 2;
                Console.WriteLine(v);            
                n = n / 2;
            }
            Console.Read();
        }

        private static void AsyncSamples()
        {
            //try
            //{

            //    Task task = new Task(
            //     () => {
            //         throw new Exception("ff");
            //     }
            //           );
            //    task.Start();

            //    task.GetAwaiter().GetResult();
            //}
            //catch
            //{
            //    Console.WriteLine("Exception");
            //}
            AsyncAwaitExceptionHandling obj = new AsyncAwaitExceptionHandling();
            obj.MainTaskAsync();
        }

        private static void CoinChange()
        {
            var cache = DP_CoinChange.BuildAllPossibleCache(new int[3] { 1, 2, 3 }, 4);
        }

        public int FindNumberOfPalindromes(string input)
        {
            int noOfPalindrome = 0;
            //check whether palindormes can be made or not 

            return noOfPalindrome;
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
