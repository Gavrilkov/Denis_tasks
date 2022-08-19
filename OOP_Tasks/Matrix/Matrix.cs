using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class Matrix
    {
        int columns;
        int rows;
        int[,] Ar = new int[0, 0];
        Random r = new Random();
        public Matrix(int rows, int columns)
        {
            int[,] Ar = new int[rows, columns];
            this.Ar = Ar;
            this.rows = rows;
            this.columns = columns;
        }

        public void init()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Ar[i, y] = r.Next(10);
                   // Console.Write(Ar[i, y] + "\t");
                }
              //  Console.WriteLine();
            }
        }

        //public override string tostring()
        //{

        //    return $" {Ar}";
        //}

        public void showmatrixadd(Matrix m1, Matrix m2)
        {
            for (int i = 0; i < m1.rows; i++)
            {
                for (int y = 0; y < m1.columns; y++)
                {
                    Console.Write(m1.Ar[i, y] + "\t"); ;
                }
                Console.WriteLine();
            }
            Console.WriteLine('+' + "\t");
            for (int i = 0; i < m2.rows; i++)
            {
                for (int y = 0; y < m2.columns; y++)
                {
                    Console.Write(m2.Ar[i, y] + "\t"); ;
                }
                Console.WriteLine();
            }
            Console.WriteLine('=' + "\t");

            for (int i = 0; i < m2.rows; i++)
            {
                for (int y = 0; y < m2.columns; y++)
                {
                    Console.Write((m1.Ar[i, y] + m2.Ar[i, y]) + "\t"); ;
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix m3 = new Matrix(m1.rows, m1.columns);
            for (int i = 0; i < m1.rows; i++)
            {
                for (int y = 0; y < m1.columns; y++)
                {
                    m3.Ar[i, y] = m1.Ar[i, y] + m2.Ar[i, y];
                }
            }
            return m3;
        }

    }
}
