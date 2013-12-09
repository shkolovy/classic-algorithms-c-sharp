namespace SortingAlgorithms
{
    public static class QuickSort
    {
        public static void QuickSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            QuickSortTemp(array, 0, array.Length - 1);
        }

        private static void QuickSortTemp(int[] collection, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var separateItem = collection[((leftIndex + rightIndex) / 2)];

            do
            {
                while (collection[i] < separateItem)
                {
                    i++;
                }

                while (collection[j] > separateItem)
                {
                    j--;
                }

                if (i <= j)
                {
                    if (i < j)
                    {
                        collection.Swap(i, j);
                    }

                    i++; j--;
                }

            } while (i < j);

            if (leftIndex < j)
                QuickSortTemp(collection, leftIndex, j);

            if (i < rightIndex)
                QuickSortTemp(collection, i, rightIndex);
        }

    }
}