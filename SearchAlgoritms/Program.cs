using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = SearchHelper.GetRandomArrayWithValue(30, arrayLength: 20);

            var a = array.LinearSearch(30);

            var array1 = SearchHelper.GetSequenceRandomArrayWithValue(15, arrayLength: 20); ;

            var b = array1.BinarySearch(15);

            Console.ReadKey();
        }
    }
}
