namespace SortingAlgorithms
{
    public static class HeapSort
    {
        public static void HeapSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            var arrayLength = array.Length;

            for (int i = arrayLength / 2 - 1; i >= 0; i--)
            {
                ShiftDown(array, i, arrayLength - 1);
            }

            var lastItemIndex = arrayLength - 1;

            while (lastItemIndex > 0)
            {
                array.Swap(0, lastItemIndex);

                ShiftDown(array, 0, --lastItemIndex);
            }
        }

        private static void ShiftDown(int[] array, int startWithIndex, int endWithIndex)
        {
            int maxItemIndex = startWithIndex;

            var leftChildIndex = startWithIndex*2 + 1;

            if (leftChildIndex <= endWithIndex && array[startWithIndex] < array[leftChildIndex])
            {
                maxItemIndex = leftChildIndex;
            }

            var rightChildIndex = leftChildIndex + 1;

            if (rightChildIndex <= endWithIndex && array[maxItemIndex] < array[rightChildIndex])
            {
                maxItemIndex = rightChildIndex;
            }

            if (maxItemIndex != startWithIndex)
            {
                array.Swap(startWithIndex, maxItemIndex);
            }

            if (maxItemIndex != startWithIndex)
            {
                ShiftDown(array, maxItemIndex, endWithIndex);
            }
        }
    }
}