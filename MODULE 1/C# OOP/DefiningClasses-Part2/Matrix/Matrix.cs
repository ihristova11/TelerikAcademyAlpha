using System;

namespace Matrix
{
    public class Matrix<T>
        where T : IComparable
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rowsCount, int colsCount)
        {
            this.rows = rowsCount;
            this.cols = colsCount;
            this.matrix = new T[rowsCount, colsCount];
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            T[,] resultMatrix = new T[]
        }
    }
}
