using System;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    public class Shell
    {
        public static void Sort<T>(T[] data) where T : IComparable<T>
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }

            var h = GenerateH(data.Length);

            while (h > 0)
            {
                for (var i = h; i < data.Length; i++)
                {
                    for (var j = i; j >= h; j -= h)
                    {
                        if (data[j].CompareTo(data[j - h]) < 0)
                        {
                            Utils.Exchange(data, j, j - h);
                            continue;
                        }
                        break;

                    }
                }

                h = NextH(h);
            }

        }

        public static void Sort<T>(T[] data, IComparer<T> comparer)
        {
            var h = GenerateH(data.Length);

            while (h > 0)
            {
                for (var i = h; i < data.Length; i++)
                {
                    for (var j = i; j >= h && comparer.Compare(data[j], data[j - h]) < 0; j -= h)
                    {
                        Utils.Exchange(data, j, j - h);
                    }
                }

                h = NextH(h);
            }
        }

        private static int GenerateH(int size)
        {
            var h = 1;
            while (h < size / 3)
            {
                h = 3 * h + 1;
            }
            return h;
        }

        private static int NextH(int currentH)
        {
            return currentH = currentH / 3;
        }
    }
}