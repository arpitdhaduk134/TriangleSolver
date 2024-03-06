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

        [Test]
        public void TestScaleneTriangle1()
        {
            int A = 2;
            int B = 3;
            int C = 4;
            string result = Triangle.AnalyzeTriangle(A, B, C);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void TestScaleneTriangle2()
        {
            int A = 3;
            int B = 11;
            int C = 12;
            string result = Triangle.AnalyzeTriangle(A, B, C);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void TestScaleneTriangle3()
        {
            int A = 4;
            int B = 20;
            int C = 21;
            string result = Triangle.AnalyzeTriangle(A, B, C);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void TestScaleneTriangle4()
        {
            int A = 3;
            int B = 5;
            int C = 7;
            string result = Triangle.AnalyzeTriangle(A, B, C);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void TestScaleneTriangle5()
        {
            int A = 6;
            int B = 9;
            int C = 12;
            string result = Triangle.AnalyzeTriangle(A, B, C);
            Assert.AreEqual("Scalene triangle", result);
        }
    }
}