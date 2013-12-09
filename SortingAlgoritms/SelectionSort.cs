namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static void SelectionSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            var arrayLength = array.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    array.Swap(i, minIndex);
                }
            }
        }
    }
}