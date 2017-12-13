using System;

namespace Matrix
{
    public class Matrix<T>
        where T : IComparable
    {
        private T[,] matrix;
        

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
    }
}
