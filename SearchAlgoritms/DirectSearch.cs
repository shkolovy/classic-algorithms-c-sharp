using System.Linq;

namespace SearchAlgorithms
{
    public static class DirectSearchClass
    {
        public static int? DirectSearch(this string originalStr, string str)
        {
            char[] strArray = originalStr.ToArray();
            char[] searchStrArray = str.ToArray();

            for (int i = 0; i < strArray.Length; i++)
            {
                var j = 0;

                while (j < searchStrArray.Length)
                {
                    if (searchStrArray[j] == strArray[i + j])
                    {
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (j == searchStrArray.Length)
                {
                    return i;
                }
            }

            return null;
        }
    }
}