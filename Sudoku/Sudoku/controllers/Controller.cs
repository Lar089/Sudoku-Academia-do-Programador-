using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sudoku.model;
using Sudoku.service;


namespace Sudoku.Controllers
{
    class Controller
    {
        private static StringReader str = null;
        private static String[,] n_lines = new String[9, 9];
        private static String[,] n_columns = new String[9, 9];
        private static String[] l = new String[9];
        private static String[] c = new String[9];

        public static bool CalculateSudoku()
        {
            str = model.Sudoku.DefineSudoku();

            l = CreateLines(str);

            CreateSudoku(l);
            bool line_b = CompareLines(l);

            CreateColumns(n_columns);
            bool column_b = CompareColumns(c);

            if(line_b == true && column_b == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String[] CreateLines(StringReader str)
        {
            String[] lin = new string[9];
            for (int i = 0; i < 9; i++)
            {
                lin[i] = str.ReadLine();
            }
            return lin;
        }

        public static void CreateSudoku(String[] str)
        {
            for (int i = 0; i < 9; i++)
            {
                string[] lines_s = str[i].Split(' ');
                for (int j = 0; j < 9; j++)
                {
                    n_lines[i,j] = lines_s[j];
                    n_columns[j, i] = lines_s[j];
                }
            }
        }

        public static bool CompareLines(String[] str)
        {
            bool result = false;
            for (int i = 0; i < 9; i++)
            {
                string[] lines_s = str[i].Split(' ');
                result = service.Calculate.CalculateLC(lines_s);
                if (result == false)
                {
                    return false;
                }
            }
            return result;
        }

        public static void CreateColumns(String[,] str)
        {
            for (int i = 0; i < 9; i++)
            {
                String columns = null;
                for (int j = 0; j < 9; j++)
                {
                    columns = columns + n_columns[i, j];
                    if (j < 8)
                    {
                        columns = columns + " ";
                    }
                    
                }
                c[i] = columns;
            }
            
        }

        public static bool CompareColumns(String[] str)
        {
            bool result = false;
            for (int i = 0; i < 9; i++)
            {
                String co = str[i];
                string[] columns_s = co.Split(' ');
                result = service.Calculate.CalculateLC(columns_s);
                if(result == false)
                {
                    return false;
                }
            }
            return result;
        }

    }

    
}
