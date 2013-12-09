namespace SortingAlgorithms
{
    public static class ShellSort
    {
        public static void ShellCiuraSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            var arrayLength = array.Length;

            var stepNumber = 0;

            var step = GetStep(arrayLength, 0);

            while (step > 0)
            {
                for (int i = 0; i <= arrayLength - 1 - step; i++)
                {
                    var j = i + step;

                    while (j - step >= 0 && array[j] < array[j - step])
                    {
                        array.Swap(j - step, j);

                        j--;
                    }
                }

                step = GetStep(arrayLength, ++stepNumber);
            }
        }

        private static readonly int[] CiuraStepsIncrements = { 1, 4, 10, 23, 57, 132, 301, 701, 1750 };

        private static int GetStep(int itemsLength, int stepNumber)
        {
            if (stepNumber >= CiuraStepsIncrements.Length)
            {
                return 0;
            }

            var a = itemsLength / 2;

            var maxStepIndex = 0;

            while (maxStepIndex < CiuraStepsIncrements.Length - 1 && CiuraStepsIncrements[maxStepIndex] < a)
            {
                maxStepIndex++;
            }

            if (maxStepIndex < stepNumber)
            {
                return 0;
            }

            return CiuraStepsIncrements[maxStepIndex - stepNumber];
        }

        public static void ShellSortAsc(this int[] array)
        {
            if (array.Length <= 1)
                return;

            var arrayLength = array.Length;

            var step = arrayLength / 2;

            while (step > 0)
            {
                for (int i = 0; i <= arrayLength - 1 - step; i++)
                {
                    var j = i + step;

                    while (j - step >= 0 && array[j] < array[j - step])
                    {
                        array.Swap(j - step, j);

                        j--;
                    }
                }

                step = step / 2;
            }
        }
    }
}