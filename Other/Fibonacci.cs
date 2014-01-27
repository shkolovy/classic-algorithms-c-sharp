using System;

namespace Other
{
    //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584 ....
    public static class Fibonacci
    {
        public static int[] Calculate(int numbersCount)
        {
            if (numbersCount < 2)
            {
                throw new ArgumentException("numbersCount cannot be less than 2");
            }

            var result = new int[numbersCount];

            result[0] = 0;
            result[1] = 1;

            for (int i = 1; i < numbersCount - 1; i++)
            {
                result[i + 1] = result[i] + result[i - 1];
            }

            return result;
        }

        public static int[] CalculateWithRecursion(int numbersCount)
        {
            if (numbersCount < 2)
            {
                throw new ArgumentException("numbersCount cannot be less than 2");
            }

            var result = new int[numbersCount];

            result[0] = 0;
            result[1] = 1;

            CalculateWithRecursion(result, numbersCount, 1);

            return result;
        }

        private static void CalculateWithRecursion(int[] arr, int numbersCount, int currentNemberIndex)
        {
            if (currentNemberIndex < numbersCount - 1)
            {
                arr[currentNemberIndex + 1] = arr[currentNemberIndex] + arr[currentNemberIndex - 1];
                CalculateWithRecursion(arr, numbersCount, currentNemberIndex + 1);
            }
        }
    }
}
