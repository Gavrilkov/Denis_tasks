using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class Matrix
    {
        int _columns;
        int _rows;
        int[,] matrix;
        Random _rand;
        public Matrix(int _rows, int _columns)
        {
            matrix = new int[_rows, _columns];
            this._rows = _rows;
            this._columns = _columns;
            _rand = new Random();
        }

        public void Init()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int y = 0; y < _columns; y++)
                {
                    matrix[i, y] = _rand.Next(10);
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
                    s += $"{matrix[i, y]}" + " ";
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
                    m3.matrix[i, y] = m1.matrix[i, y] + m2.matrix[i, y];
                }
            }
            return m3;
        }
    }
}
