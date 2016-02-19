namespace Algorithms.Data
{
    static class Data
    {
        public static int[] GetSuffleIntegers(int maxElements)
        {
            var items = new int[maxElements];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = i;
            }
            Utils.Shuffle(items);

            return items;
        }

        public static int[] GetSortedIntegers(int maxElements)
        {
            var items = new int[maxElements];
            for (var i = 0; i < items.Length; i++)
            {
                items[i] = i;
            }
           
            return items;
        }

        public static int[] GetReverseSortedIntegers(int maxElements)
        {
            var items = new int[maxElements];
            for (var i = 0; i < items.Length; i++)
            {
                items[i] = items.Length-i-1;
            }

            return items;
        }

        public static int[] GetRandomIntegers(int maxElements)
        {
            var items = new int[maxElements];
            var random = new System.Random();
            for (var i = 0; i < items.Length; i++)
            {
                items[i] = random.Next(maxElements + 1);
            }

            return items;
        }
    }
}
