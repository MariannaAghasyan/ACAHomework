using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program : Object 
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8},
            };

            SquareMatrix Mat1 = new SquareMatrix(matrix);

            matrix = new int[,]
            {
                {5,2,2},
                {3,5,5},
                {0,7,8}
            };

            //Console.WriteLine("Mat1");
            //Mat1.PrintMatrix();

            SquareMatrix Mat2 = new SquareMatrix(matrix);

            SquareMatrix Mat3;

            //Mat3 = Mat1.Add(Mat2);
            Mat3 = Mat1 * Mat2;


            //Boolean b = Mat1.IsEqual(Mat2);

            //Console.WriteLine(b);

            Mat3.PrintMatrix();

        }
    }
}
