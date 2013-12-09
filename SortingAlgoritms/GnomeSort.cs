namespace SortingAlgorithms
{
    public static class GnomeSort
    {
        public static void GnomeSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            if(array.Length <= 1)
                return;

            var i = 1;

            while (i < array.Length)
            {
                if (array[i] < array[i - 1])
                {
                    array.Swap(i, i - 1);

                    if (i - 1 == 0)
                    {
                        i++;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i++;
                }
            }
        }
    }
}