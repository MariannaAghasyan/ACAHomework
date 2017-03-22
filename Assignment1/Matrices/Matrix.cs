using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    /// <summary>
    /// class Matrix represents NxM dimentional matrix.
    /// </summary>
    public partial class Matrix
    {
        /// <summary>
        /// Constructor. Contracts Matrix of the given dimantion nxm.
        /// Filed with zeros.
        /// </summary>
        /// <param name="n"> Matrix row count. </param>
        /// <param name="m"> Matrix column count. </param>
        public Matrix(Int32 n, Int32 m)
        {
            if (n <= 0 || m <= 0)
            {
                throw new System.ArgumentException("Can not create Matrix of dimentions (" + n + "x" + m + ").");
            }
            CurrentMatrix = new Int32[n, m];
        }

        /// <summary>
        /// Constructor. Constracts matrix based on the given two dimentional array.
        /// </summary>
        /// <param name="values"> Two dimentional array. </param>
        public Matrix(Int32[,] values) :
            this(values.GetUpperBound(0)+1, values.GetUpperBound(1)+1)
        {
            for (Int32 i = 0; i < RowCount; ++i)
            {
                for (Int32 j = 0; j < ColumnCount; ++j)
                {
                    CurrentMatrix[i, j] = values[i, j];
                }
            }
        }
        
        /// <summary>
        /// Copy Constractor. Constracts matrix based on the given matrix.
        /// </summary>
        /// <param name="other"> original matrix </param>
        public Matrix(Matrix other) :
            this(other.CurrentMatrix)
        {
        }

        /// <summary>
        /// Add given matrix to current matrix.
        /// </summary>
        /// <param name="other"> Matrix to be added. </param>
        /// <returns> Modifed current matrix. </returns>
        public Matrix Add(Matrix other)
        {
            if (RowCount != other.RowCount || ColumnCount != other.ColumnCount)
            {
                throw new System.ArgumentException("Matrix dimensions are different.");
            }

            for (Int32 i = 0; i < RowCount; ++i)
            {
                for (Int32 j = 0; j < ColumnCount; ++j)
                {
                    CurrentMatrix[i, j] += other.CurrentMatrix[i, j];
                }
            }

            return this;
        }

        /// <summary>
        /// Checks the equality of the current matrix with the given one.
        /// </summary>
        /// <param name="other"> Matrix to check equality with. </param>
        /// <returns> True if all the corresponding elements are equal. </returns>
        public Boolean IsEqual(Matrix other)
        {
            if (RowCount != other.RowCount || ColumnCount != other.ColumnCount)
            {
                return false;
            }
            for (Int32 i = 0; i < RowCount; ++i)
            {
                for (Int32 j = 0; j < ColumnCount; ++j)
                {
                    if (CurrentMatrix[i, j] != other.CurrentMatrix[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Multiply all the elements of current matrix by given scalar.
        /// </summary>
        /// <param name="a"> Scalar to be multiplied. </param>
        /// <returns> Modifed current matrix. </returns>
        public Matrix ScalarMultiplication(Int32 a)
        {
            for (Int32 i = 0; i < RowCount; ++i)
            {
                for (Int32 j = 0; j < ColumnCount; ++j)
                {
                    CurrentMatrix[i, j] *= a;
                }
            }
            return this;
        }

        /// <summary>
        /// Multiply the current matrix with the given one.
        /// </summary>
        /// <param name="other"> Matrix to muliplied by. </param>
        /// <returns> Modifed current matrix. </returns>
        public Matrix Multiplication(Matrix other)
        {//A(NxM)B(MxK)= C(NxK)
            if (ColumnCount != other.RowCount)
            {
                throw new System.ArgumentException("Matrix dimension are different.");
            }

            Int32[,] newMatrix = new Int32[RowCount, other.ColumnCount];

            for (Int32 i = 0; i < RowCount; ++i)
            {
                for (Int32 j = 0; j < other.ColumnCount; ++j)
                {
                    Int32 ij = 0;
                    for (Int32 l = 0; l < ColumnCount; ++l)
                    {
                        ij += CurrentMatrix[i, l] * other.CurrentMatrix[l, j];
                    }
                    newMatrix[i, j] = ij;
                }
            }

            return new Matrix(newMatrix);
        }

        /// <summary>
        /// Outputs cuurent matrix to console.
        /// </summary>
        public void PrintMatrix()
        {
            for (Int32 i = 0; i < RowCount; ++i)
            {
                for (Int32 j = 0; j < ColumnCount; ++j)
                {
                    Console.Write(CurrentMatrix[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
 
        /// <summary>
        /// The inner matrix.
        /// </summary>
        public Int32[,] CurrentMatrix
        {
            get;
            protected set;
        }

        /// <summary>
        /// Matrix row count.
        /// </summary>
        public Int32 RowCount
        {
            get { return CurrentMatrix.GetUpperBound(0) + 1; }
        }

        /// <summary>
        /// Matrix column count.
        /// </summary>
        public Int32 ColumnCount
        {
            get { return CurrentMatrix.GetUpperBound(1) + 1; }
        }
    }
}
