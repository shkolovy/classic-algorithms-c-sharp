namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        public static void InsertionSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            for (int i = 1; i < array.Length; i++)
            {
                var j = i;

                while (j > 0 && array[j] < array[j - 1])
                {
                    if (array[j] < array[j - 1])
                    {
                        array.Swap(j - 1, j);
                    }

                    j--;
                }
            }
        }

    }
}