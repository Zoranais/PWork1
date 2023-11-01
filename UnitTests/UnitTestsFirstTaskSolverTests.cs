using Microsoft.VisualStudio.TestTools.UnitTesting;
using pr1f.Services;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTestsFirstTaskSolverTests
    {
        [TestMethod]
        public void Calculate_AllValuesMultipleOfFive_ReturnsSum()
        {
            var a = 5;
            var b = 5;
            var c = 5;

            var solver = new UnitTestsFirstTaskSolver(a, b, c);
            Assert.AreEqual(a + b + c, solver.Calculate());
        }

        [TestMethod]
        public void Calculate_OnlyOneValueMultipleOfFive_ReturnsCubeOfSum()
        {
            var a = 1;
            var b = 2;
            var c = 5;

            var solver = new UnitTestsFirstTaskSolver(a, b, c);
            Assert.AreEqual(Math.Pow(a + b + c, 3), solver.Calculate());
        }

        [TestMethod]
        public void Calculate_NoValuesMultipleOfFive_ReturnsCubeOfSum()
        {
            var a = 1;
            var b = 2;
            var c = 3;

            var solver = new UnitTestsFirstTaskSolver(a, b, c);
            Assert.AreEqual(Math.Pow(a + b + c, 3), solver.Calculate());
        }
    }
}
