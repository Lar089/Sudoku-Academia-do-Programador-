using System;
using System.IO;
using Sudoku.model;
using Sudoku.Controllers;

namespace Sudoku
{
    public class App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Definindo o Sudoku \n");
            StringReader str = model.Sudoku.DefineSudoku();
            while (str.Peek() > -1)
            {
                Console.WriteLine(str.ReadLine());
            }
            bool result = Controller.CalculateSudoku();
            Console.WriteLine("Resultado:");
            Console.WriteLine($"{result}");

        }
    }
}
