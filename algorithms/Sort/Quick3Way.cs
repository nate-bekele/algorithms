using System;

namespace Algorithms.Sort
{
    public class Quick3Way
    {
        public static void Sort<T>(T[] data) where T : IComparable<T>
        {
            Utils.Shuffle(data);
            Sort(data, 0, data.Length-1);
        }

        private static void Sort<T>(T[] data, int lo, int hi) where T : IComparable<T>
        {

            if (lo > hi) return;

            var v = data[lo];
            var i = lo;
            var lt = lo;
            var ge = hi;

            while (i <= ge)
            {
                var cmp = data[i].CompareTo(v);

                if (cmp < 0)
                {
                    Utils.Exchange(data, lt++, i++);
                }
                else if (cmp > 0)
                {
                    Utils.Exchange(data, i, ge--);
                }
                else
                {
                    i++;
                }
            }

            Sort(data, lo, lt - 1);
            Sort(data, ge + 1, hi);
        }

    }
}
