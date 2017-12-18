namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Problem2
    {
        static void Main()
        {
            //testing
            var list = new List<int>();
            list.Add(4);
            list.Add(8);

            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Product());
            Console.WriteLine(list.Average());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
        }

        public static T Sum<T>(this IEnumerable<T> enumerable)
            where T : IComparable
        {
            dynamic result = 0;

            foreach (var item in enumerable)
            {
                result += item;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> enumerable)
            where T : IComparable
        {
            dynamic result = 1;

            foreach (var item in enumerable)
            {
                result *= item;
            }
            return result;
        }

        public static T Average<T>(this IEnumerable<T> enumerable)
            where T : IComparable
        {
            dynamic result = 0;

            foreach (var item in enumerable)
            {
                result += item;
            }

            result /= enumerable.Count();

            return result;
        }

        public static T Min<T>(this IEnumerable<T> enumerable)
            where T : IComparable
        {
            dynamic result = int.MaxValue;

            foreach (var item in enumerable)
            {
                result = result > item ? item : result;
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> enumerable)
            where T : IComparable
        {
            dynamic result = int.MinValue;

            foreach (var item in enumerable)
            {
                result = result < item ? item : result;
            }

            return result;
        }
    }
}
