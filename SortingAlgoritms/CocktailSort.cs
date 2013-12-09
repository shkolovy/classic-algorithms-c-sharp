namespace SortingAlgorithms
{
    public static class CocktailSort
    {
        public static void CocktailSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            var leftIndex = 0;
            var rightIndex = array.Length - 1;

            while (leftIndex < rightIndex)
            {
                var i = leftIndex;
                var isSorted = true;

                while (i < rightIndex)
                {
                    if (array[i] > array[i + 1])
                    {
                        array.Swap(i + 1, i);
                        isSorted = false;
                    }

                    i++;
                }

                if(isSorted)
                    break;

                var j = rightIndex - 1;
                isSorted = true;

                while (j > leftIndex)
                {
                    if (array[j] < array[j - 1])
                    {
                        array.Swap(j - 1, j);
                        isSorted = false;
                    }

                    j--;
                }

                if (isSorted)
                    break;

                leftIndex++;
                rightIndex--;
            }
        } 
    }
}