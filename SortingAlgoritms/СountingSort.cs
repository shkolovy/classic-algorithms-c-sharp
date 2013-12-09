namespace SortingAlgorithms
{
    public static class СountingSort
    {
        public static void СountingSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            int maxValue = array[0];
            int minValue = array[0];

            for(var i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] > maxValue)
                {
                    maxValue = array[i + 1];
                }
                else if (array[i + 1] < minValue)
                {
                    minValue = array[i + 1];
                }
            }

            var countsArray = new int[maxValue - minValue + 1];

            foreach (int item in array)
            {
                countsArray[item - minValue]++;
            }

            var currentIndex = 0;

            for (var i = 0; i < countsArray.Length; i++)
            {
                for (var j = 0; j < countsArray[i]; j++)
                {
                    array[currentIndex++] = i + minValue;
                }
            }
        }
    }
}