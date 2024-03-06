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
    }
}