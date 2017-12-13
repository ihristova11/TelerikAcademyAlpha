namespace Matrix
{
    using System;
    using System.Text;

    public class Matrix<T>
        where T : IComparable
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rowsCount, int colsCount)
        {
            this.Rows = rowsCount;
            this.Cols = colsCount;
            this.matrix = new T[rowsCount, colsCount];
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }
                
                this.matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("rows count", "The matrix must have at least one row.");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("columns count", "The matrix must have at least one column.");
                }
                this.cols = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new Exception("Addition cannot be applied to matrices with different dimensions.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new Exception("Addition cannot be applied to matrices with different dimensions.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if(firstMatrix.Rows != secondMatrix.Cols)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);
            T temp;

            for (int matrixRow = 0; matrixRow < result.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < result.Cols; matrixCol++)
                {
                    temp = (dynamic)0;

                    for (int index = 0; index < result.Cols; index++)
                    {
                        temp += (dynamic)firstMatrix[matrixRow, matrixCol] * secondMatrix[matrixRow, matrixCol];
                    }
                    result[matrixRow, matrixCol] = (dynamic)temp;
                }
            }
            return result;
        }

        public static bool OverrideBool(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if(matrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(this.matrix[row, col] + "\t");
                }
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
