namespace SortableCollection
{
    class SortableCollection
    {
        static void Main()
        {
            int[] numbers = {1, 5, 4, 2, 7, -1, 0};
        }

        public static int LinearSearch(int[] numbers, int desired)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == desired)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
