using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMathFunctions.Test
{
    [TestClass]
    public class AdditionTests
    {
        Arithmetic Maths;

        [TestInitialize]
        public void Setup()
        {
            Maths = new Arithmetic();
        }

        [TestMethod]
        public void Addition_2IntergerNumbers()
        {
            int num1 = 2;
            int num2 = 3;

            var sum = Maths.Addition(num1, num2);

            Assert.AreEqual(sum, 5);
        }

        [TestMethod]
        public void Addition_2IntergerNegativeNumbers()
        {
            int num1 = -2;
            int num2 = -4;

            var sum = Maths.Addition(num1, num2);

            Assert.AreEqual(sum, -6);
        }

        [TestMethod]
        public void Addition_2IntergerNumbersFalseTest()
        {
            int num1 = 7;
            int num2 = -4;

            var sum = Maths.Addition(num1, num2);

            Assert.AreNotEqual(sum, -20);
        }

        [TestMethod]
        public void Addition_2DecimalNumbers()
        {
            decimal num1 = 2.5m;
            decimal num2 = 3.4m;

            var sum = Maths.Addition(num1, num2);

            Assert.AreEqual(sum, 5.9m);
        }

        [TestMethod]
        public void Addition_2DecimalNegativeNumbers()
        {
            decimal num1 = -7.5m;
            decimal num2 = -15.3m;

            var sum = Maths.Addition(num1, num2);

            Assert.AreEqual(sum, -22.8m);
        }

        [TestMethod]
        public void Addition_2DecimalNumbersFalseTest()
        {
            decimal num1 = 2.5m;
            decimal num2 = 3.4m;

            var sum = Maths.Addition(num1, num2);

            Assert.AreNotEqual(sum, -20);
        }

        [TestMethod]
        public void Addition_2StringNumbers()
        {
            string num1 = "17.9";
            string num2 = "5";

            var sum = Maths.Addition(num1, num2);

            Assert.AreEqual(sum, 22.9m);
        }

        [TestMethod]
        public void Addition_2StringNegativeNumbers()
        {
            string num1 = "-99";
            string num2 = "-2.4";

            var sum = Maths.Addition(num1, num2);

            Assert.AreEqual(sum, -101.4m);
        }

        [TestMethod]
        public void Addition_2StringNumbersFalseTest()
        {
            string num1 = "76";
            string num2 = "-5";

            var sum = Maths.Addition(num1, num2);

            Assert.AreNotEqual(sum, 5.9m);
        }
    }
}
