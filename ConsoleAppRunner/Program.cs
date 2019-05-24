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
            Sudoku();
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
