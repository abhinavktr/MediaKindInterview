using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Sudoku
    {
        public bool Validate(int[,] input)
        {
            int[] rows, columns;
            int[,] box;
            //validate row
            //validate columns
            //validate 3*3
            box = new int[10, 10];
            for (int i = 0; i < 9; i++)
            {
                rows = new int[10];
                columns = new int[10];                
                for (int j = 0; j < 9; j++)
                {
                    var rowValue = input[i, j];
                    var colValue = input[j, i];

                    //assume this as 2D array, where first dimension is referring to each of 9 squares.
                    var boxIndex = (int)((3 * Math.Floor((decimal)i / 3)) + (Math.Floor((decimal)j / 3)));

                    if (rows[rowValue] != default)
                        return false;
                    rows[rowValue] = rowValue;
                    if (columns[colValue] != default)
                        return false;
                    columns[colValue] = colValue;

                    //for box
                    if (box[boxIndex, rowValue] == default)
                        box[boxIndex, rowValue] = rowValue;
                    else
                        return false;                   
                }
            }
            //validate 3*3 mtrix
            return true;
        }

        public bool ValidateBox(int rowIndex,int colIndex)
        {
            //get the row index
            var rowlimit = Math.Floor((decimal)rowIndex / 3) * 3;
            var colLimit = Math.Floor((decimal)colIndex / 3) * 3;
            
            return true;
        }

        //Using backtacking approach
        public bool Solve(int[,] input)
        {
            bool isEmpty = true;
            int row = -1, col = -1;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (input[i, j] == 0)
                    {
                        row = i;
                        col = j;
                        isEmpty = false;
                    }
                }
                if (!isEmpty) break;
            }
            for (int num = 1; num <= 9; num++)
            {
                if (Validate(input))
                {
                    input[row, col] = num;
                    if (Solve(input))
                    {                        
                        return true;
                    }
                    else
                    {
                        input[row, col] = 0; // replace it 
                    }
                }
            }
            return false;
        }
    }
}
