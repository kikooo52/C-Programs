using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {


            Matrix<int> someMatrix = new Matrix<int>(3, 3);

            someMatrix[0, 0] = 111;
            someMatrix[0, 1] = 7;
            someMatrix[0, 2] = 9;

            someMatrix[1, 0] = 22;
            someMatrix[1, 1] = 3;
            someMatrix[1, 2] = 56;

            someMatrix[2, 0] = 11;
            someMatrix[2, 1] = 126;
            someMatrix[2, 2] = 37;

            Matrix<int> newMatrix = new Matrix<int>(3, 3);

            newMatrix[0, 0] = 11;
            newMatrix[0, 1] = 72;
            newMatrix[0, 2] = 9;

            newMatrix[1, 0] = 22;
            newMatrix[1, 1] = 13;
            newMatrix[1, 2] = 5;

            newMatrix[2, 0] = 1;
            newMatrix[2, 1] = 12;
            newMatrix[2, 2] = 3;

            Matrix<int> bashMatrica = new Matrix<int>(someMatrix.Row, newMatrix.Cols);
            bashMatrica = someMatrix + newMatrix;
            bashMatrica = someMatrix - newMatrix;
            bashMatrica = someMatrix * newMatrix - someMatrix;
            for (int i = 0; i < bashMatrica.Row; i++)
            {
                for (int j = 0; j < bashMatrica.Cols; j++)
                {
                    Console.Write("{0,5}", bashMatrica[i, j]);         
                }
                Console.WriteLine();
            }
            if (bashMatrica)
            {
                Console.WriteLine(true);       // Check for 0
            }
            else
            {
                Console.WriteLine(false);
            }

  

        }
    }
}
