using System;
using System.Linq;

namespace Algorithms.Sort
{
    public class Counting
    {
        /// <summary>
        /// Data keys should be between range 
        /// i.e for all keys k, is bewteen rangeStart and rangeEnd
        /// </summary>
        /// <param name="data"></param>
        /// <param name="rangeStart"></param>
        /// <param name="rangeEnd"></param>
        public static void Sort(int[] data, int rangeStart, int rangeEnd)
        {

            if (data == null || data.Length < 1)
            {
                throw new ArgumentNullException();
            }

            if (rangeStart > rangeEnd && IsAllKeysBetweenRange(data, rangeStart, rangeEnd))
            {
                throw new ArgumentException(string.Format("Invalid range values (from > to)"));
            }

            // count the occurance of each key in the array
            var count = new int[rangeEnd - rangeStart + 1];
            foreach (int t in data)
            {
                count[t - rangeStart]++;
            }

            var currentIndex = 0;
            for (var i = rangeStart; i <= rangeEnd; i++)
            {
                var orginialCount = count[i - rangeStart];
                while (orginialCount > 0 )
                {
                    data[currentIndex++] = rangeStart;
                    orginialCount--;
                }
            }
        }

        private static bool IsAllKeysBetweenRange(int[] data, int rangeStart, int rangeEnd)
        {
            return data.All(t => t >= rangeStart && t <= rangeEnd);
        }
    }
}
