using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class Matrix
    {
        int _columns;
        int _rows;
        int[,] _matrix;
        Random _rand;

        public Matrix(int rows, int columns)
        {
            _matrix = new int[_rows, _columns];
            this._rows = rows;
            this._columns = columns;
            _rand = new Random();
        }

        public void Init()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int y = 0; y < _columns; y++)
                {
                    _matrix[i, y] = _rand.Next(10);
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < _rows; i++)
            {
                for (int y = 0; y < _columns; y++)
                {
                    s += $"{_matrix[i, y]}" + " ";
                }
                s += "\n";
            }
            return s;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix m3 = new Matrix(m1._rows, m1._columns);
            for (int i = 0; i < m1._rows; i++)
            {
                for (int y = 0; y < m1._columns; y++)
                {
                    m3._matrix[i, y] = m1._matrix[i, y] + m2._matrix[i, y];
                }
            }
            return m3;
        }
    }
}
