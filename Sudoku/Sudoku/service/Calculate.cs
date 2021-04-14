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
                    if ((_sudoku[i].Equals(_sudoku[j])))// && (i != j)
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
    }
}
