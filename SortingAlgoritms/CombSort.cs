namespace SortingAlgorithms
{
    public static class CombSort
    {
        public static void CombSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            const double shrink = 1.3;

            bool isSorted = false;
            int step = array.Length - 1;

            while (step >= 1 && !isSorted)
            {
                var i = 0;

                //use isSorted only for bubble sort (step = 1)
                if (step == 1)
                {
                    isSorted = true;
                }

                while (i + step < array.Length)
                {
                    if (array[i] > array[i + step])
                    {
                        array.Swap(i, i + step);
                        isSorted = false;
                    }

                    i++;
                }

                if (step > 1)
                {
                    step = (int)(step / shrink);
                }
            }
        }
    }
}