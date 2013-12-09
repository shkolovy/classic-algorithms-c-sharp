using System;

namespace SortingAlgorithms
{
    public static class BogoSort
    {
        public static void BogoSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            while (!array.IsSorted())
            {
                var random = new Random();

                for (var i = 0; i < array.Length; i++)
                {
                    array.Swap(i, random.Next(0, array.Length));
                }
            }
        }
    }
}