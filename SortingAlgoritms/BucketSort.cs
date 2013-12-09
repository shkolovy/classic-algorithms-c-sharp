using System.Collections.Generic;

namespace SortingAlgorithms
{
    public static class BucketSort
    {
        public static void BucketSortAsc(this int[] array, int bucketsNumber = 10)
        {
            if (array.Length <= 1)
                return;

            int maxValue = array[0];
            int minValue = array[0];

            for (var i = 0; i < array.Length - 1; i++)
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

            int bucketRange = (maxValue - minValue) / bucketsNumber;

            var bucketsArray = new int[bucketsNumber][];

            var currentBucketRangeStartWith = minValue;

            for (var i = 0; i < bucketsArray.Length; i++)
            {
                var bucket = new List<int>();

                foreach (int item in array)
                {
                    if (item >= currentBucketRangeStartWith && item <= currentBucketRangeStartWith + bucketRange)
                    {
                        bucket.Add(item);
                    }
                }

                bucketsArray[i] = bucket.ToArray();

                bucketsArray[i].QuickSortAsc();

                currentBucketRangeStartWith = currentBucketRangeStartWith + bucketRange + 1;
            }

            var c = 0;

            foreach (int[] bucket in bucketsArray)
            {
                foreach (int item in bucket)
                {
                    array[c++] = item;
                }
            }
        }
    }
}