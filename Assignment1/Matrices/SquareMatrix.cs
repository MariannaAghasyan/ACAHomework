using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    /// <summary>
    /// class SquareMatrix represents NxN dimentional matrix.
    /// </summary>
    public class SquareMatrix : Matrix 
    {
        /// <summary>
        /// Constructor. Contracts SquareMatrix of the given dimantion n.
        /// Filed with zeros.
        /// </summary>
        /// <param name="n"> Dimention </param>
        public SquareMatrix(Int32 n) : base(n, n)
        {
        }

        /// <summary>
        /// Constructor. Constracts square matrix based on the given square two dimentional array.
        /// </summary>
        /// <param name="values"> Square two dimentional array. </param>
        public SquareMatrix(Int32[,] values) : base(values)
        {
            if (values.GetUpperBound(0) != values.GetUpperBound(1))
            {
                throw new System.ArgumentException("Matrix is not square.");
            }
        }

        /// <summary>
        /// Copy Constractor. Constracts square matrix based on the given square matrix.
        /// </summary>
        /// <param name="other"> original square matrix </param>
        public SquareMatrix (Matrix matrix) : base(matrix.CurrentMatrix)
        {
            if (matrix.RowCount != matrix.ColumnCount)
            {
                throw new System.ArgumentException("Matrix is not square.");
            }
        }

        /// <summary>
        /// Add given square matrix to current square matrix.
        /// </summary>
        /// <param name="other"> Square matrix to be added. </param>
        /// <returns> Modifed current square matrix. </returns>
        public SquareMatrix Add(SquareMatrix other)
        {
            return (SquareMatrix)base.Add(other);
        }

        /// <summary>
        /// Checks the equality of the current square matrix with the given one.
        /// </summary>
        /// <param name="other"> square matrix to check equality with. </param>
        /// <returns> True if all the corresponding elements are equal. </returns>
        public new SquareMatrix ScalarMultiplication(Int32 a)
        {
            return (SquareMatrix)base.ScalarMultiplication(a);
        }

        /// <summary>
        /// Multiply the current square matrix with the given one.
        /// </summary>
        /// <param name="other"> Square matrix to muliplied by. </param>
        /// <returns> Modifed current square matrix. </returns>
        public SquareMatrix Multiplication(SquareMatrix other)
        {
            return (SquareMatrix)base.Multiplication(other);
        }

        /// <summary>
        ///  The sum of two square matrices.
        /// </summary>
        /// <param name="otherA"> First summand. </param>
        /// <param name="otherB"> Second summand. </param>
        /// <returns> The sum of two matrices. </returns>
        public static SquareMatrix operator + (SquareMatrix otherA, SquareMatrix otherB)
        {
            return new SquareMatrix(otherA as Matrix + otherB);
        }

        /// <summary>
        /// The prodact of two square matrices.
        /// </summary>
        /// <param name="otherA"> First operand. </param>
        /// <param name="otherB"> Second operand. </param>
        /// <returns> The prodact of two matrices. </returns>
        public static SquareMatrix operator * (SquareMatrix otherA, SquareMatrix otherB)
        {
            return new SquareMatrix ((otherA as Matrix) * otherB);
        }

        /// <summary>
        /// Constrats an identity matrix of the given dimention n.
        /// The identity matrix is a diagonal matrix with 1s on the main diagonal.
        /// </summary>
        /// <param name="n"> Dimention </param>
        /// <returns> Identity matrix of the given. </returns>
        public static SquareMatrix IdentityMatrix (Int32 n)
        {
            SquareMatrix newMatrix = new SquareMatrix(n);
            for (Int32 i = 0; i < n; ++i)
            {
                newMatrix.CurrentMatrix[i, i] = 1;
            }
            return newMatrix; 
        }

        /// <summary>
        /// Constracts a zero matrix of the given dimention.
        /// The zero matrix is square matrix filed by zeros.
        /// </summary>
        /// <param name="n"> Dimention </param>
        /// <returns> Zero matrix </returns>
        public static SquareMatrix ZeroMatrix(Int32 n)
        {
            return new SquareMatrix(n);
        }
    }


}

