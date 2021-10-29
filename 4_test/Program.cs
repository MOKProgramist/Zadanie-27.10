using System;

namespace _4_test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            int y = 0;
            while (x)
            {
                Console.WriteLine(y);
                y += 1;

                if (y >= 500000) x = false;
            }

            var startTime = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 2499; i++)
            {
                LQL.Rem();
            }

            startTime.Stop();
            var resultTime = startTime.Elapsed;

            // elapsedTime - строка, которая будет содержать значение затраченного времени
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                resultTime.Hours,
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);
        }
    }
}
