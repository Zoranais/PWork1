using Microsoft.VisualStudio.TestTools.UnitTesting;
using pr1f.Services;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTestsSecondTaskSolverTests
    {
        [TestMethod]
        public void Calculate_1To7_Returns7()
        {
            var solver = new UnitTestsSecondTaskSolver(1, 7);
            Assert.AreEqual(7, solver.Calculate());
        }
        [TestMethod]
        public void Calculate_1To6_Returns0()
        {
            var solver = new UnitTestsSecondTaskSolver(1, 6);
            Assert.AreEqual(0, solver.Calculate());
        }
        [TestMethod]
        public void Calculate_1To35_Returns57624()
        {
            var solver = new UnitTestsSecondTaskSolver(1, 35);
            Assert.AreEqual(57624, solver.Calculate());
        }
    }
}
