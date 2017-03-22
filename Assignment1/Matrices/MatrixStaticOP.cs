using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    public partial class Matrix
    {
        /// <summary>
        ///  The sum of two matrices.
        /// </summary>
        /// <param name="otherA"> First summand. </param>
        /// <param name="otherB"> Second summand. </param>
        /// <returns> The sum of two matrices. </returns>
        public static Matrix operator + (Matrix otherA, Matrix otherB)
        {
            if (otherA.RowCount != otherB.RowCount || otherA.ColumnCount != otherB.ColumnCount)
            {
                throw new System.ArgumentException("Matrix dimension are different.");
            }

            Int32 rows = otherA.RowCount;
            Int32 columns = otherA.ColumnCount;
            Int32[,] newMatrix = new Int32[rows, columns];
            for (Int32 i = 0; i < rows; ++i)
            {
                for (Int32 j = 0; j < columns; ++j)
                {
                    newMatrix[i, j] = otherA.CurrentMatrix[i, j] + otherB.CurrentMatrix[i, j];
                }
            }

            return new Matrix(newMatrix);
        }

        /// <summary>
        /// The prodact of two matrices.
        /// </summary>
        /// <param name="otherA"> First operand. </param>
        /// <param name="otherB"> Second operand. </param>
        /// <returns> The prodact of two matrices. </returns>
        public static Matrix operator * (Matrix otherA, Matrix otherB)
        {
            if (otherA.ColumnCount != otherB.RowCount)
            {
                throw new System.ArgumentException("Matrix dimension are different.");
            }

            Int32 rows = otherA.RowCount;
            Int32 columns = otherB.ColumnCount;
            Int32[,] newMatrix = new Int32[rows, columns];
            for (Int32 i = 0; i < rows; ++i)
            {
                for (Int32 j = 0; j < columns; ++j)
                {
                    Int32 ij = 0;
                    for (Int32 l = 0; l < otherA.ColumnCount; ++l)
                    {
                        ij += otherA.CurrentMatrix[i, l] * otherB.CurrentMatrix[l, j];
                    }
                    newMatrix[i, j] = ij;
                }
            }

            return new Matrix(newMatrix);
        }

    }


}
