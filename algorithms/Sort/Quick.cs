using System;

namespace Algorithms.Sort
{
    public class Quick
    {
        public static void Sort<T>(T[] data) where T : IComparable<T>
        {
            Utils.Shuffle(data);
            Sort(data, 0, data.Length - 1);
        }

        private static int Partition<T>(T[] data, int lo, int hi) where T : IComparable<T>
        {
            var i = lo;
            var j = hi;

            var v = data[lo];

            while (i <= j)
            {
                while (i <= j && data[i].CompareTo(v) <=0)
                {
                    i++;
                }

                while (i <= j && data[j].CompareTo(v) >= 0)
                {
                    j--;
                }

                if (i > j) break;
                Utils.Exchange(data,i,j);
            }

            Utils.Exchange(data, lo, j);
            return j;
        }

        private static void Sort<T>(T[] data, int lo, int hi) where T : IComparable<T>
        {

            if (lo > hi) return;

            var pivot = Partition(data, lo, hi);
            Sort(data, lo, pivot - 1);
            Sort(data, pivot + 1, hi);
        }

    }
}
