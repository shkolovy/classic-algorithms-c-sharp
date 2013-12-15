using System.Linq;

namespace SearchAlgorithms
{
    public static class KPMSearchClass
    {
        public static int? KPMSearch(this string originalStr, string str)
        {
            char[] strArray = originalStr.ToArray();
            char[] searchStrArray = str.ToArray();

            var i = 0;
            var j = 0;

            while (i < strArray.Length)
            {
                if (strArray[i] == searchStrArray[j])
                {
                    if (j == searchStrArray.Length - 1)
                    {
                        return i - j;
                    }

                    j++;
                }
                else
                {
                    j = 0;
                }

                i++;
            }

            return null;
        }
    }
}