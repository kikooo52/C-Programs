using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RotatingWalkInMatrixTests
{
    [TestClass]
    public class TestsMatrix
    {
        [TestMethod]
        public void GenerateRotationMatrixTestWhitTwo()
        {
            const int n = 2;
            int[,] expected =
            {
                {1, 4},
                {3, 2}             
            };
            int[,] result = RotatingWalkInMatrix.GenerateRotationgMatrix(n);

            string expectedString = MatrixToString(expected);
            string resultString = MatrixToString(result);

            bool areEqual = (expectedString.Equals(resultString, StringComparison.InvariantCultureIgnoreCase));
            Assert.AreEqual(true, areEqual);


        }

        [TestMethod]
        public void GenerateRotationMatrixTestWhitFife()
        {
            const int n = 5;
            int[,] expected =
            {
                { 1, 13, 14,15, 16},
                { 12,  2, 21, 22, 17},
                { 11, 23,  3, 20, 18},
                { 10, 25, 24,  4, 19},
                {  9,  8,  7,  6,  5}
                
            };
            int[,] result = RotatingWalkInMatrix.GenerateRotationgMatrix(n);

            string expectedString = MatrixToString(expected);
            string resultString = MatrixToString(result);

            bool areEqual = (expectedString.Equals(resultString, StringComparison.InvariantCultureIgnoreCase));
            Assert.AreEqual(true, areEqual);


        }

        [TestMethod]
        public void GenerateRotationMatrixTestWhitSeven()
        {
            const int n = 7;
            int[,] expected =
            {
                {1, 19, 20, 21, 22, 23, 24},
                {18,  2, 33, 34, 35, 36, 25},
                {17, 40,  3, 32, 39, 37, 26},
                {16, 48, 41,  4, 31, 38, 27},
                {15, 47, 49, 42,  5, 30, 28},
                {14, 46, 45, 44, 43,  6, 29},
                {13, 12, 11, 10,  9,  8,  7}
                
            };
            int[,] result = RotatingWalkInMatrix.GenerateRotationgMatrix(n);

            string expectedString = MatrixToString(expected);
            string resultString = MatrixToString(result);

            bool areEqual = (expectedString.Equals(resultString, StringComparison.InvariantCultureIgnoreCase));
            Assert.AreEqual(true, areEqual);


        }

        private string MatrixToString(int[,] matrix)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    stringBuilder.Append(matrix[i, j]);
                }
            }
            return stringBuilder.ToString();
        }
    }
}