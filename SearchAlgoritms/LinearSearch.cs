namespace SearchAlgorithms
{
    public static class LinearSearchClass
    {
        public static int? LinearSearch(this int[] array, int key)
        {
            foreach (var item in array)
            {
                if (item == key)
                    return item;
            }

            return null;
        }
    }
}