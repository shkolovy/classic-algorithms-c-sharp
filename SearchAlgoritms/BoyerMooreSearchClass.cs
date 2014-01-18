using System.Linq;

namespace SearchAlgorithms
{
    public static class BoyerMooreSearchClass
    {
        /*
        hoola-hoola girls like hooligans
        hooligan
        *****hooligan
        *******hooligan
        ***************hooligan
        ***********************hooligan
        */
        public static int? BoyerMooreSearch(this string originalStr, string str)
        {
            char[] strArray = originalStr.ToArray();
            char[] searchStrArray = str.ToArray();

            int indexStart = 0;

            while (indexStart <= strArray.Length - searchStrArray.Length)
            {
                int j = indexStart + searchStrArray.Length - 1;
                int i = searchStrArray.Length - 1;

                while (i >= 0)
                {
                    if (searchStrArray[i] == strArray[j])
                    {
                        if (i == 0)
                        {
                            return indexStart;
                        }

                        i--;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }

                int shiftIndex = GetShiftIndex(strArray[indexStart + searchStrArray.Length - 1], searchStrArray);

                indexStart = indexStart + shiftIndex;
            }

            return -1;
        }

        private static int GetShiftIndex(char charToMatch, char[] searchStrArray)
        {
            int index = 0;

            for (int i = searchStrArray.Length - 1; i >= 0; i--)
            {
                if (searchStrArray[i] == charToMatch)
                {
                    if (index == 0)
                    {
                        return i;
                    }

                    return index;
                }

                index++;
            }

            return index;
        }
    }
}