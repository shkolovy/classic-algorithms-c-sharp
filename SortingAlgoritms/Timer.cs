using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public class Timer : IDisposable
    {
        private readonly Stopwatch _stopwatch;

        public Timer()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        public void Dispose()
        {
            _stopwatch.Stop();
            DisplayTimespan();
        }

        private void DisplayTimespan()
        {
            TimeSpan ts = _stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);

            Console.WriteLine(elapsedTime);
        }
    }
}