using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matricess;

namespace LinearEquations
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal[,] variable = { { 6, -2, 1 }, { 1, 2, -5 }, { -2, 7, 2 } };
            decimal[] constants = { 11, -1, 5 };
            //decimal[,] variable = { { 17, -2, -3 }, { -5, 21, -2 }, { -5, -5, 22 } };
            //decimal[] constants = { 500, 200, 30 };
            decimal[] result = new decimal[constants.Length];   //here result is given default of zero already

            for (int i = 0; i < constants.Length; i++)
            {
                for (int j = 0; j < constants.Length; j++)
                {

                    //     MatrixManipulation.DisplayResult(MatrixManipulation.Inverse(variable, 3));
                    result[i] += MatrixManipulation.Inverse(variable, 3)[i, j] * constants[j]; // row multiply by column
        }
    }

            foreach (decimal results in result)
            {
                Console.WriteLine(Math.Round(results)); // prints out the answer;
            }
Console.ReadKey();
        }
    }
}
