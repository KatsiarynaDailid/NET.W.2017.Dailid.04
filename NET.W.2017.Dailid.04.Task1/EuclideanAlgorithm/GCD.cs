using System;
using System.Diagnostics;

namespace EuclideanAlgorithm
{
    public static class GCD
    {
        /// <summary>
        /// Count GCD for two numbers using Euclidean algorithm
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <param name="ms">Time of algorithm work</param>
        /// <returns>GCD of two numbers</returns>
        public static int GCDCount(int firstNumber, int secondNumber, out double ms)
        {
            #region Set veriables

            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);
            ms = 0;
            Stopwatch stopWatch = new Stopwatch();

            #endregion

            #region Input validation

            if (firstNumber == 0)
                return secondNumber;

            if (secondNumber == 0)
                return firstNumber;

            #endregion

            stopWatch.Start();         

            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                    firstNumber = firstNumber - secondNumber;
                else
                    secondNumber = secondNumber - firstNumber;
            }

            stopWatch.Stop();

            ms = stopWatch.Elapsed.TotalMilliseconds;

            return firstNumber;
        }

        /// <summary>
        /// Count GCD for more than two numbers using Euclidean algorithm
        /// </summary>
        /// <param name="ms">Time of algorithm work</param>
        /// <param name="array">Array of numbers</param>
        /// <returns>GCD of numbers from array</returns>
        public static int GCDCount(out double ms, params int[] array)
        {
            int gcd = GCDCount(array[0], array[1], out ms);

            for (int i = 2; i < array.Length; i++)
            {
                gcd = GCDCount(array[i], gcd, out ms);
            }

            return gcd;
        }

        /// <summary>
        /// Count GCD for two numbers using binary Euclidean algorithm
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <param name="ms">Time of algorithm work</param>
        /// <returns>GCD of two numbers</returns>
        public static int GCDCountBinary(int firstNumber, int secondNumber, out double ms)
        {
            #region Set veriables

            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);
            ms = 0;

            #endregion

            #region Input validation

            if (firstNumber == secondNumber)
                return firstNumber;

            if (firstNumber == 0)
                return secondNumber;

            if (secondNumber == 0)
                return firstNumber;

            #endregion

            if ((firstNumber % 2) == 0) 
            {
                if (secondNumber % 2 == 1) 
                    return GCDCount(firstNumber / 2, secondNumber, out ms);
                else
                    return 2 * GCDCount(firstNumber / 2, secondNumber / 2, out ms);
            }

            if (firstNumber % 2 == 1 && secondNumber % 2 == 0)
                return GCDCount(firstNumber, secondNumber / 2, out ms);

            if (secondNumber > firstNumber)
                return GCDCount((secondNumber - firstNumber) / 2, firstNumber, out ms);

            else
                return GCDCount((firstNumber - secondNumber) / 2, secondNumber, out ms);


        }


        /// <summary>
        /// Count GCD for more than two numbers using binary Euclidean algorithm
        /// </summary>
        /// <param name="ms">Time of algorithm work</param>
        /// <param name="array">Array of numbers</param>
        /// <returns>GCD of numbers from array</returns>
        public static int GCDCountBinary(out double ms, params int[] array)
        {

            int gcd = GCDCountBinary(array[0], array[1], out ms);

            for (int i = 2; i < array.Length; i++)
            {
                gcd = GCDCountBinary(array[i], gcd, out ms);
            }

            return gcd;
        }


    }
}
