namespace Algorithms.Sort
{
    using System;

    public class Binary
    {
        public static int Search<T>(T[] data, T term) where T : IComparable<T>
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }

            return Search(data, 0, data.Length - 1, term);
        }

        private static int Search<T>(T[] data, int low, int high, T term) where T : IComparable<T>
        {
            while (low < high)
            {
                var middle = low + (high - low) / 2;

                if (data[middle].CompareTo(term) < 0)
                {
                    high = middle - 1;
                    continue;
                }

                if (data[middle].CompareTo(term) > 0)
                {
                    low = middle + 1;
                    continue;
                }

                return middle;
            }
            return -1;
        }
    }
}
