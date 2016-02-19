using System;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    public class Insertion
    {
        public static void Sort<T>(T[] data) where T : IComparable<T>
        {
            for (var i = 1; i < data.Length; i++)
            {
                for (var j = i; j > 0 && data[j].CompareTo(data[j - 1]) < 0; j--)
                {
                    Utils.Exchange(data, j, j - 1);
                }
            }
        }

        public static void Sort<T>(T[] data, IComparer<T> comparer)
        {
            for (var i = 1; i < data.Length; i++)
            {
                for (var j = i; j > 0 && comparer.Compare(data[j], data[j - 1]) < 0; j--)
                {
                    Utils.Exchange(data, j, j - 1);
                }
            }
        }
    }
}
