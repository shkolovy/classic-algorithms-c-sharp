namespace SearchAlgorithms
{
    //делением пополам
    public static class BinarySearchClass
    {
        public static int? BinarySearch(this int[] array, int key)
        {
            return array.Search(key, 0, array.Length - 1);
        }

        private static int? Search(this int[] array, int key, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return null;
            }

            int midIndex = (leftIndex + rightIndex)/2;

            if (array[midIndex] == key)
            {
                return array[midIndex];
            }

            if (array[midIndex] > key)
            {
                return array.Search(key, leftIndex, midIndex - 1);
            }

            return array.Search(key, midIndex + 1, rightIndex);
        }
    }
}