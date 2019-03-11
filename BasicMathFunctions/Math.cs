using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathFunctions
{
    public class Arithmetic
    {
        #region Addition
        public int Addition(int numA, int numB)
        {
            return numA + numB;
        }
        public decimal Addition(decimal numA, decimal numB)
        {
            return numA + numB;
        }
        public decimal Addition(string numA, string numB)
        {

            return Convert.ToDecimal(numA) + Convert.ToDecimal(numB);
        }
        public decimal Addition(double numA, double numB)
        {

            return Convert.ToDecimal(numA) + Convert.ToDecimal(numB);
        }
        #endregion

        #region Subtraction
        public int Subtraction(int numA, int numB)
        {
            return numA - numB;
        }
        public decimal Subtraction(string numA, string numB)
        {

            return Convert.ToDecimal(numA) - Convert.ToDecimal(numB);
        }
        public decimal Subtraction(decimal numA, decimal numB)
        {
            return numA - numB;
        }
        public decimal Subtraction(double numA, double numB)
        {

            return Convert.ToDecimal(numA) - Convert.ToDecimal(numB);
        }
        #endregion

        #region Multiplication
        public int Multiplication(int numA, int numB)
        {
            return numA * numB;
        }
        public decimal Multiplication(string numA, string numB)
        {

            return Convert.ToDecimal(numA) * Convert.ToDecimal(numB);
        }
        public decimal Multiplication(double numA, double numB)
        {

            return Convert.ToDecimal(numA) * Convert.ToDecimal(numB);
        }
        public decimal Multiplication(decimal numA, decimal numB)
        {
            return numA * numB;
        }
        #endregion

        #region Division
        public int Division(int numA, int numB)
        {
            return numA / numB;
        }
        public decimal Division(decimal numA, decimal numB)
        {
            return numA + numB;
        }
        public decimal Division(string numA, string numB)
        {

            return Convert.ToDecimal(numA) / Convert.ToDecimal(numB);
        }
        public decimal Division(double numA, double numB)
        {

            return Convert.ToDecimal(numA) / Convert.ToDecimal(numB);
        }
        #endregion
    }
}
