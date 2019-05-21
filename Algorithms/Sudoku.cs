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
    }
}
