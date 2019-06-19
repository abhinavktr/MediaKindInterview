using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class DP_CoinChange
    {
        //Problem: Get min no of coins, also the denomination to get a change for a particular sum\capacity

        //Build the cache(2D array) with min number of coins required 
        public static int[,] BuildAllPossibleCache(int[] denominations, int capacity)
        {
            int[,] mem = new int[denominations.Length+1, capacity+1];
            for (int i = 1; i < capacity+1; i++)
            {
                mem[0, i] = i;
            }

            for (int i = 1; i < denominations.Length + 1; i++)
            {
                for (int j = 1; j < capacity+1 ; j++)
                {
                    //If current denomination is equal to Capacity , then add it as is
                    if (denominations[i - 1] == j)
                        mem[i, j] = 1;
                    else if (denominations[i - 1] > j)  //If current denomination is greater than Capacity, add the upper one
                    {
                        mem[i, j] = mem[i - 1, j];
                    }
                    else //if current denomination is less than Capacity, add the one, and subtract it from Capacity and look for remaining term
                    {
                        int switchOff = mem[i - 1, j];
                        int switchOn = mem[i,(j - denominations[i-1])] + 1;
                        mem[i,j] = Math.Min(switchOn, switchOff);
                    }
                }
            }
            return mem;
        }
    }
}
