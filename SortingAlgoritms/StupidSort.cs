namespace SortingAlgorithms
{
    public static class StupidSort
    {
        public static void StupidSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            var i = 0;

            while (i < array.Length - 1)
            {
                if (array[i] > array[i + 1])
                {
                    array.Swap(i + 1, i);

                    i = 0;
                }
                else
                {
                    i++;
                }
            }
        } 
    }
}