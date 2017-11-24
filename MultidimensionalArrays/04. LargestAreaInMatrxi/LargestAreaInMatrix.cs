namespace _04.LargestAreaInMatrxi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LargestAreaInMatrix
    {
        private static Stack<int> _branchingCellCol;
        private static Stack<int> _branchingCellRow;
        private static int[,] _table;
        private static bool[,] _visitedCells;
        private static int _rows;
        private static int _cols;
        private static int _maxAreaSize;
        private static int _currentAreaSize;

        static void Main()
        {
            Console.WriteLine(CheckMatrix(_table, _cols, _rows));
        }

        private static void Initialize(int[,] table, int cols, int rows)
        {
            _branchingCellCol = new Stack<int>();
            _branchingCellRow = new Stack<int>();
            InitializeVisitedCells(cols, rows);
            _table = table;
            _cols = cols;
            _rows = rows;
            _maxAreaSize = 0;
            _currentAreaSize = 0;
        }



        private static void InitializeVisitedCells(int cols, int rows)
        {
            _visitedCells = new bool[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    _visitedCells[row, col] = false;
                }
            }
        }



        private static bool IsBranching(int row, int col)
        {
            int currentValue = _table[row, col];
            if (col - 1 >= 0 && _table[row, col - 1] == currentValue &&
                IsVisited(row, col - 1) == false) //left
            {
                return true;
            }
            else if (col + 1 < _cols && _table[row, col + 1] == currentValue &&
                IsVisited(row, col + 1) == false)//right
            {
                return true;
            }
            else if (row - 1 >= 0 && _table[row - 1, col] == currentValue &&
                IsVisited(row - 1, col) == false)//up
            {
                return true;
            }
            else if (row + 1 < _rows && _table[row + 1, col] == currentValue &&
                IsVisited(row + 1, col) == false)//down
            {
                return true;
            }

            return false;
        }


        private static bool IsVisited(int row, int col)
        {
            return _visitedCells[row, col];
        }


        public static int CheckMatrix(int[,] table, int cols, int rows)
        {
            Initialize(table, cols, rows);

            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _cols; col++)
                {
                    if (_visitedCells[row, col] == false && IsBranching(row, col) == true)
                    {
                        _branchingCellCol.Push(col);
                        _branchingCellRow.Push(row);
                        Explore(col, row);
                    }
                }
            }

            return _maxAreaSize;
        }


        private static void Explore(int col, int row)
        {
            int currentValue = _table[row, col];
            //_currentAreaSize++;
            while (_branchingCellCol.Count > 0 && _branchingCellRow.Count > 0)
            {
                col = _branchingCellCol.Pop();
                row = _branchingCellRow.Pop();


                int colTemp = col;
                int rowTemp = row;
                while (colTemp - 1 >= 0 && _table[rowTemp, colTemp - 1] == currentValue &&
                    IsVisited(rowTemp, colTemp - 1) == false) //left
                {
                    colTemp = colTemp - 1;
                    //rowTemp = rowTemp;
                    _branchingCellCol.Push(colTemp);
                    _branchingCellRow.Push(rowTemp);
                    _visitedCells[rowTemp, colTemp] = true;
                    _currentAreaSize++;

                }

                colTemp = col;
                rowTemp = row;
                while (colTemp + 1 < _cols && _table[rowTemp, colTemp + 1] == currentValue &&
                    IsVisited(rowTemp, colTemp + 1) == false)//right
                {
                    colTemp = colTemp + 1;
                    //rowTemp = rowTemp;
                    _branchingCellCol.Push(colTemp);
                    _branchingCellRow.Push(rowTemp);
                    _visitedCells[rowTemp, colTemp] = true;
                    _currentAreaSize++;
                }

                colTemp = col;
                rowTemp = row;
                while (rowTemp - 1 >= 0 && _table[rowTemp - 1, colTemp] == currentValue &&
                   IsVisited(rowTemp - 1, colTemp) == false)//up
                {
                    //colTemp = colTemp;
                    rowTemp = rowTemp - 1;
                    _branchingCellCol.Push(colTemp);
                    _branchingCellRow.Push(rowTemp);
                    _visitedCells[rowTemp, colTemp] = true;
                    _currentAreaSize++;
                }

                colTemp = col;
                rowTemp = row;
                while (rowTemp + 1 < _rows && _table[rowTemp + 1, colTemp] == currentValue &&
                    IsVisited(rowTemp + 1, colTemp) == false)//down
                {
                    //colTemp = colTemp;
                    rowTemp = rowTemp + 1;
                    _branchingCellCol.Push(colTemp);
                    _branchingCellRow.Push(rowTemp);
                    _visitedCells[rowTemp, colTemp] = true;
                    _currentAreaSize++;
                }
            }

            if (_currentAreaSize > _maxAreaSize)
            {
                _maxAreaSize = _currentAreaSize;
            }
            _currentAreaSize = 0;
        }


    }
}
