using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main()
        {
            int[] array = SortingHelper.GetRandomArray(10000);

            //Distribution
            SortingTimer.Go(ar => ar.СountingSortAsc(), SortingHelper.GetRandomArray(1000, 0, 255), "Сounting Sort");
            SortingTimer.Go(ar => ar.BucketSortAsc(), SortingHelper.GetRandomArray(1000, 0, 255), "Bucket Sort");

            //Exchange 
            SortingTimer.Go(ar => ar.StupidSortAsc(), SortingHelper.GetRandomArray(100), "Stupid Sort");
            SortingTimer.Go(ar => ar.BubbleSortAsc(), SortingHelper.GetRandomArray(100), "Bubble Sort");
            SortingTimer.Go(ar => ar.BubbleSortEnhancedAsc(), SortingHelper.GetRandomArray(100), "Bubble Sort Enhanced");
            SortingTimer.Go(ar => ar.OddEvenSortAsc(), array.CloneArray(), "OddEven Sort");
            SortingTimer.Go(ar => ar.GnomeSortAsc(), array.CloneArray(), "Gnome Sort");
            SortingTimer.Go(ar => ar.CocktailSortAsc(), array.CloneArray(), "Cocktail Sort");
            SortingTimer.Go(ar => ar.CombSortAsc(), array.CloneArray(), "Comb Sort");
            SortingTimer.Go(ar => ar.QuickSortAsc(), array.CloneArray(), "Quick Sort");
            SortingTimer.Go(ar => ar.BogoSortAsc(), SortingHelper.GetRandomArray(5, 0, 5), "Bogo Sort");

            //Merge
            SortingTimer.Go(ar => ar.MergeSortAsc(), array.CloneArray(), "Merge Sort");

            //Insertion
            SortingTimer.Go(ar => ar.InsertionSortAsc(), array.CloneArray(), "Insertion Sort");
            SortingTimer.Go(ar => ar.ShellSortAsc(), array.CloneArray(), "Shell Sort");
            SortingTimer.Go(ar => ar.ShellCiuraSortAsc(), array.CloneArray(), "Shell Ciura Sort");

            //Selection
            SortingTimer.Go(ar => ar.SelectionSortAsc(), array.CloneArray(), "Selection Sort");
            SortingTimer.Go(ar => ar.HeapSortAsc(), array.CloneArray(), "Heap Sort");


            Console.WriteLine("\n-----END-----");
            Console.Read();
        }
    }
}
