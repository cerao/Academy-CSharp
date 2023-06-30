using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class MatrixClass

    {
        public int[,] Matrix;
        public MatrixClass() 
        {
            Matrix = new int[2, 2];
        }

        public void FillMatrix()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                  var ReadElement = Console.ReadLine();

                    if (int.TryParse(ReadElement,out int Element))
                    {
                        Matrix[i,j] = Element;
                    }
                }
            }
        }
            
        public void Print()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(Matrix[i, j] + " ");
                }
            }
        }
        public static implicit operator int(MatrixClass Matrix)
        {
            var IntNamber = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    IntNamber += Matrix.Matrix[i, j];
                }
            }
            return IntNamber;
        }

        public static explicit operator string(MatrixClass Matrix)
        {
            string TOString = default;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    TOString = Matrix.Matrix[i, j].ToString();
                }
            }
            return TOString;
        }
        public static MatrixClass operator +(MatrixClass Matrix, MatrixClass Matrix2)
        {
            MatrixClass Matrix3 = new MatrixClass();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matrix3.Matrix[i, j] = Matrix.Matrix[i, j] + Matrix2.Matrix[i, j];
                }
            }
            return Matrix3;
        }
        public static MatrixClass operator -(MatrixClass Matrix, MatrixClass Matrix2)
        {
            MatrixClass Matrix3 = new MatrixClass();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matrix3.Matrix[i, j] = Matrix.Matrix[i, j] - Matrix2.Matrix[i, j];
                }
            }
            return Matrix3;
        }
        public static MatrixClass operator *(MatrixClass Matrix, MatrixClass Matrix2)
        {
            MatrixClass Matrix3 = new MatrixClass();

            Matrix3.Matrix[0, 0] = Matrix.Matrix[0, 0] * Matrix2.Matrix[0, 0] + Matrix2.Matrix[0, 1] * Matrix2.Matrix[1, 0];
            Matrix3.Matrix[0, 1] = Matrix.Matrix[0, 0] * Matrix2.Matrix[0, 1] + Matrix2.Matrix[0, 1] * Matrix2.Matrix[1, 1];


            Matrix3.Matrix[1, 0] = Matrix.Matrix[1, 0] * Matrix2.Matrix[0, 0] + Matrix2.Matrix[1, 1] * Matrix2.Matrix[1, 0];
            Matrix3.Matrix[1, 1] = Matrix.Matrix[1, 0] * Matrix2.Matrix[0, 1] + Matrix2.Matrix[1, 1] * Matrix2.Matrix[1, 1];

            return Matrix3;
        }
        public static MatrixClass operator -(MatrixClass Matrix)
        {
            MatrixClass Matrix3 = new MatrixClass();

            Matrix3.Matrix[0, 0] = Matrix.Matrix[1, 1];
            Matrix3.Matrix[1, 1] = Matrix.Matrix[0, 0];


            Matrix3.Matrix[1, 0] = -Matrix.Matrix[1, 0];
            Matrix3.Matrix[0, 1] = -Matrix.Matrix[0, 1];

            return Matrix3;
        }
        public override string ToString()
        {
            return this.Matrix[0, 0].ToString();
        }
    }
}
