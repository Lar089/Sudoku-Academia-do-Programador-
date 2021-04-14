using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sudoku.model
{
    class Sudoku
    {
        public static StringReader DefineSudoku()
        {
            StringReader str = new StringReader("1 3 2 5 7 9 4 6 8" + "\n" +
                                                "4 9 8 2 6 1 3 7 5" + "\n" +
                                                "7 5 6 3 8 4 2 1 9" + "\n" +
                                                "6 4 3 1 5 8 7 9 2" + "\n" +
                                                "5 2 1 7 9 3 8 4 6" + "\n" +
                                                "9 8 7 4 2 6 5 3 1" + "\n" +
                                                "2 1 4 9 3 5 6 8 7" + "\n" +
                                                "3 6 5 8 1 7 9 2 4" + "\n" +
                                                "8 7 9 6 4 2 1 5 3");
            return str;
    }
    }
}
