using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku.service
{
    class Calculate
    {
        public static bool CalculateLC(String[] _sudoku)
        {
            for(int i = 0; i < _sudoku.Length; i++)
            {
                for (int j = 0; j < _sudoku.Length; j++)
                {
                    if ((_sudoku[i].Equals(_sudoku[j])))
                    {
                        if(i != j)
                        {
                            return false;
                        }
                        
                    }
                }
            }
            return true;
        }

        public static bool CalculateBlock(String[,] l_sudoku, String[,] str_blocks)
        {
            int l = 0;
            for (int k = 0; k < 9; k++)
            {
                l = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int x = i + k % 3 * 3;
                        int y = j + k / 3 * 3;
                        str_blocks[k, l] = l_sudoku[x, y];
                        l++;
                    }
                }
            }
            return true;
        }

    }
}
