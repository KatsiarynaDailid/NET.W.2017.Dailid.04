using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EuclideanAlgorithm.Tests
{
    [TestClass]
    public class GCDTests
    {
        [DataRow(1071, 462, 21)]
        [DataRow(-1071, -462, 21)]
        [DataRow(-1071, 462, 21)]
        [DataRow(-1071, 0, 1071)]
        [DataRow(0, -462, 462)]
        [DataTestMethod]
        public void GCDCount_TwoNumbers_GCD(int firstNumber, int secondNumber, int expectedResult)
        {
            double time = -1;
            int actualResult = GCD.GCDCount(firstNumber, secondNumber, out time);

            Assert.AreEqual(actualResult, expectedResult, "GCD is incorrect.");
            Assert.IsTrue(time >= 0, "GCD algorithm is not started");
        }

        [DataRow(1071, 462, 21)]
        [DataRow(-1071, -462, 21)]
        [DataRow(-1071, 462, 21)]
        [DataRow(-1071, 0, 1071)]
        [DataRow(0, -462, 462)]
        [DataTestMethod]
        public void GCDCountBinary_TwoNumbers_GCD(int firstNumber, int secondNumber, int expectedResult)
        {
            double time = -1;
            int actualResult = GCD.GCDCountBinary(firstNumber, secondNumber, out time);

            Assert.AreEqual(actualResult, expectedResult, "GCD is incorrect.");
            Assert.IsTrue(time >= 0, "GCD algorithm is not started");
        }
        
        [DataRow(9, new[] {252, 441, 1080})]
        [DataRow(9, new[] { -252, -441, 1080})]
        [DataRow(9, new[] { -252, 441, 1080})]
        [DataRow(36, new[] { 252, 0, 1080 })]
        [DataRow(9, new[] { 0, 441, 1080 })]
        [DataRow(63, new[] { 252, 441, 0 })]
        [DataRow(9, new[] { 252, 441, 0, 1080, 36, 72 })]
        [DataTestMethod]
        public void GCDCount_MoreThanTwoNumbers_GCD(int expectedResult, params int[] array)
        {
            double time = -1;
            int actualResult = GCD.GCDCount(out time, array);

            Assert.AreEqual(actualResult, expectedResult, "GCD is incorrect.");
            Assert.IsTrue(time >= 0, "GCD algorithm is not started");

        }

        [DataRow(9, new[] { 252, 441, 1080 })]
        [DataRow(9, new[] { -252, -441, 1080 })]
        [DataRow(9, new[] { -252, 441, 1080 })]
        [DataRow(9, new[] { 0, 441, 1080 })]
        [DataRow(36, new[] { 252, 0, 1080 })]     
        [DataRow(63, new[] { 252, 441, 0 })]
        [DataRow(9, new[] { 252, 441, 0, 1080, 36, 72 })]
        [DataTestMethod]
        public void GCDCountBinary_MoreThanTwoNumbers_GCD(int expectedResult, params int[] array)
        {
            double time = -1;
            int actualResult = GCD.GCDCountBinary(out time, array);

            Assert.AreEqual(actualResult, expectedResult, "GCD is incorrect.");
            Assert.IsTrue(time >= 0, "GCD algorithm is not started");

        }
    }
}
