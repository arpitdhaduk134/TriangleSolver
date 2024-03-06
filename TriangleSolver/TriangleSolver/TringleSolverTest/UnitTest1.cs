using TriangleSolver;
using NUnit.Framework;

namespace TringleSolverTest
{
    public class Tests
    {
        [Test]
        public void TestEquilateralTriangle()
        {
            int A = 3;
            int B = 3;
            int C = 3;
            string result = Triangle.AnalyzeTriangle(A, B, C);
            Assert.AreEqual("Equilateral triangle", result);
        }

        [Test]
        public void TestIsoscelesTriangle1()
        {
            int A = 3;
            int B = 3;
            int C = 2;
            string result = Triangle.AnalyzeTriangle(A, B, C);
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void TestIsoscelesTriangle2()
        {
            int A = 2;
            int B = 3;
            int C = 3;
            string result = Triangle.AnalyzeTriangle(A, B, C);
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void TestIsoscelesTriangle3()
        {
            int A = 3;
            int B = 2;
            int C = 3;
            string result = Triangle.AnalyzeTriangle(A, B, C);
            Assert.AreEqual("Isosceles triangle", result);
        }

    }
}