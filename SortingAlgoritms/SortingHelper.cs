using System;

namespace SortingAlgorithms
{
    public static class SortingHelper
    {
        public static bool IsSorted(this int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static void InverseSort(this int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            var i = 0;
            var j = array.Length - 1;

            while (i < j)
            {
                array.Swap(j, i);

                i++;
                j--;
            }
        }

        public static void Swap(this int[] array, int index1, int index2)
        {
            var el = array[index1];
            array[index1] = array[index2];
            array[index2] = el;
        }

        public static int[] GetRandomArray(int arrayLength, int minValue = 0, int maxValue = 100)
        {
            var array = new int[arrayLength];
            var r = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = r.Next(minValue, maxValue);
            }

            return array;
        }

        public static int[] CloneArray(this int[] collection)
        {
            return (int[])collection.Clone();
        }
    }
}