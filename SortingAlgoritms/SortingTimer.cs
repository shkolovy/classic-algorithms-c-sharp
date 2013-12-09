using System;

namespace SortingAlgorithms
{
    public static class SortingTimer
    {
        public static void Go(Action<int[]> sort, int[] array, string displayName)
        {
            Console.WriteLine("{0} ({1} elements)", displayName, array.Length);
            using (new Timer())
            {
                sort(array);
            }

            Console.WriteLine("---------------------------");
        }
    }
}