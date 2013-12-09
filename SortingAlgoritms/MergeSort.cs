namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void MergeSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            array.MergeSortAscTemp(0, array.Length - 1);
        }

        private static void MergeSortAscTemp(this int[] array, int leftIndex, int rightIndex)
        {
            if (rightIndex > leftIndex)
            {
                var midIndex = (leftIndex + rightIndex) / 2;

                array.MergeSortAscTemp(leftIndex, midIndex);
                array.MergeSortAscTemp(midIndex + 1, rightIndex);

                array.Merge(leftIndex, rightIndex, midIndex);
            }
        }

        private static void Merge(this int[] array, int leftIndex, int rightIndex, int midIndex)
        {
            var mergedArrayLength = rightIndex - leftIndex + 1;

            var firstArrayLeftIndex = leftIndex;
            var firstArrayRightIndex = midIndex;

            var secondArrayLeftIndex = midIndex + 1;
            var secondArrayRightIndex = rightIndex;

            var tempArray = new int[mergedArrayLength];
            var tempArrayCurrentIndex = 0;

            while (firstArrayLeftIndex <= firstArrayRightIndex && secondArrayLeftIndex <= secondArrayRightIndex)
            {
                if (array[firstArrayLeftIndex] > array[secondArrayLeftIndex])
                {
                    tempArray[tempArrayCurrentIndex] = array[secondArrayLeftIndex];
                    secondArrayLeftIndex++;
                }
                else
                {
                    tempArray[tempArrayCurrentIndex] = array[firstArrayLeftIndex];
                    firstArrayLeftIndex++;
                }

                tempArrayCurrentIndex++;
            }

            while (firstArrayLeftIndex <= firstArrayRightIndex)
            {
                tempArray[tempArrayCurrentIndex] = array[firstArrayLeftIndex];
                firstArrayLeftIndex++;
                tempArrayCurrentIndex++;
            }

            while (secondArrayLeftIndex <= secondArrayRightIndex)
            {
                tempArray[tempArrayCurrentIndex] = array[secondArrayLeftIndex];
                secondArrayLeftIndex++;
                tempArrayCurrentIndex++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[leftIndex + i] = tempArray[i];
            }
        }
    }
}