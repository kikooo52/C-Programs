using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Matrix
{
    class Matrix<T>  
    {
        private T[,] matrix;
        private int cols;
        private int rows;

        public Matrix()
        { 
        }
        public Matrix(int Rows, int Cols)
        {
            if (Rows > 0 && Cols > 0)
            {
                this.cols = Cols;
                this.rows = Rows;
                this.matrix = new T[Rows, Cols];
            }
            else
            {
                throw new IndexOutOfRangeException("Out of range");
            }
        }
        public int Row
        {
            get { return this.rows; }
            set {this.rows = value; }
        }

        public int Cols
        {
            get { return this.cols; }
            set { this.cols = value; }
        }

        public T this[int row, int col]
        {
            get { return matrix[row, col]; }

            set
            {
                if ((row >= 0 && row < rows) && (col >= 0 && col < cols))
                {
                    matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.cols != second.cols || first.rows != second.rows)
            {
                throw new FormatException("Rows and Colls on the this matrices must to be equal");
            }
            else
            {
                Matrix<T> tempArray = new Matrix<T>(first.cols, second.rows);
                for (int i = 0; i < first.rows; i++)
                {
                    for (int j = 0; j < first.cols; j++)
                    {
                        tempArray[i, j] = (dynamic) first[i, j] + second[i, j];
                    }
                }
                return tempArray;
            }
        }


        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.cols == second.cols && first.rows == second.rows)
            {
                Matrix<T> tempArray = new Matrix<T>(first.cols, second.rows);
                for (int i = 0; i < first.rows; i++)
                {
                    for (int j = 0; j < first.cols; j++)
                    {
                        tempArray[i, j] = (dynamic)first[i, j] - second[i, j];
                    }
                }
                return tempArray;
            }
            else
            {
                throw new FormatException("Rows and Colls on the this matrices must to be equal");
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.cols == second.cols && first.rows == second.rows)
            {
                Matrix<T> tempArray = new Matrix<T>(first.cols, second.rows);
                for (int i = 0; i < first.rows; i++)
                {
                    for (int j = 0; j < first.cols; j++)
                    {
                        tempArray[i, j] = (dynamic)first[i, j] * second[i, j];
                    }
                }
                return tempArray;
            }
            else
            {
                throw new FormatException("Rows and Colls on the this matrices must to be equal");
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {       
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if ((dynamic)matrix[i,j] == 0)
                    {
                        return true;               
                    }
                }
               
            }
            return false;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

    }
}
