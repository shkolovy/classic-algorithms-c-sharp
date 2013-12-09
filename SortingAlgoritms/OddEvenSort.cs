namespace SortingAlgorithms
{
    public static class OddEvenSort
    {
        public static void OddEvenSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            var isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < array.Length - 1; i = i + 2)
                {
                    if (array[i] > array[i + 1])
                    {
                        array.Swap(i, i + 1);
                        isSorted = false;
                    }
                }

                for (int i = 1; i < array.Length - 1; i = i + 2)
                {
                    if (array[i] > array[i + 1])
                    {
                        array.Swap(i, i + 1);
                        isSorted = false;
                    }
                }
            }
        }
    }
}