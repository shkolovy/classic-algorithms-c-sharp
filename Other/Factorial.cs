namespace Other
{
    //7! = 1·2·3·4·5·6·7 = 5040
    public static class Factorial
    {
        public static int CalculateWithRecursion(int number)
        {
            return Calculate(number, number);
        }

        private static int Calculate(int number, int result)
        {
            if (number > 1)
            {
                return Calculate(--number, result*number);
            }

            return result;
        }

        public static int Calculate(int number)
        {
            int result = number;

            while (number > 1)
            {
                result = result*--number;
            }

            return result;
        }
    }
}