using System;
using SortingAlgorithms;

namespace SearchAlgorithms
{
    public static class SearchHelper
    {
        public static int[] GetRandomArrayWithValue(int value, int arrayLength = 100, int minValue = 0, int maxValue = 100, bool uniq = true)
        {
            var array = GetRandomArray(arrayLength, minValue, maxValue, uniq);

            if (!IsHasValue(array, value))
            {
                var r = new Random();
                array[r.Next(0, arrayLength)] = value;
            }

            return array;
        }

        public static int[] GetRandomArray(int arrayLength = 100, int minValue = 0, int maxValue = 100, bool uniq = true)
        {
            var array = new int[arrayLength];
            var r = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                var value = r.Next(minValue, maxValue);

                while (uniq && IsHasValue(array, value))
                {
                    value = r.Next(minValue, maxValue);
                }

                array[i] = value;
            }

            return array;
        }

        public static int[] GetSequenceRandomArrayWithValue(int value, int arrayLength = 100, int minValue = 0, int maxValue = 100, bool uniq = true)
        {
            var array = GetRandomArrayWithValue(value, arrayLength, minValue, maxValue, uniq);
            array.QuickSortAsc();

            return array;
        }


        private static bool IsHasValue(int[] array, int value)
        {
            foreach (var item in array)
            {
                if (item == value)
                {
                    return true;
                }
            }

            return false;
        }
    }
}