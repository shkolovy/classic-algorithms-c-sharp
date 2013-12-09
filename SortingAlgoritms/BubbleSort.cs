namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void BubbleSortEnhancedAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            var i = array.Length - 1;

            var isSorted = false;

            while (i > 0 && !isSorted)
            {
                var j = 0;

                isSorted = true;

                while (j < i)
                {
                    if (array[j] > array[j + 1])
                    {
                        array.Swap(j + 1, j);
                        isSorted = false;
                    }

                    j++;
                }

                i--;
            }
        }

        public static void BubbleSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            var itemsLength = array.Length;

            bool isSorted;

            do
            {
                isSorted = true;

                for (var i = 0; i < itemsLength - 1; i++)
                {
                    if (i < itemsLength - 1)
                    {
                        if (array[i + 1] < array[i])
                        {
                            isSorted = false;
                            array.Swap(i + 1, i);
                        }
                    }
                }
            } while (!isSorted);
        }
    }
}