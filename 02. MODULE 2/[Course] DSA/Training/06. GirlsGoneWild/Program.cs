using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.GirlsGoneWild
{
    public class GirlsGoneWild
    {
        private static SortedSet<string> results = new SortedSet<string>();

        private static List<List<int>> peopleComb = new List<List<int>>();
        private static List<List<char>> shirtsComb = new List<List<char>>();

        private static int[] combinations;
        private static int people;
        private static char[] shirts;

        public static void Main()
        {
            combinations = new int[int.Parse(Console.ReadLine())];
            shirts = Console.ReadLine().ToCharArray().OrderBy(x => x).ToArray();
            people = int.Parse(Console.ReadLine());

            Comb(0, 0, combinations, (x) => peopleComb.Add(new List<int>(x)));
            combinations = new int[shirts.Length];
            Comb(0, 0, combinations, (x) =>
            {
                var list = new List<char>();
                for (int i = 0; i < people; i++)
                {
                    list.Add(shirts[x[i]]);
                }
                shirtsComb.Add(list);
            });

            foreach (var combinationOfPeople in peopleComb)
            {
                foreach (var combinationOfShirt in shirtsComb)
                {
                    var permutationsOfShirts = new List<char>(combinationOfShirt);
                    PermuteRep(permutationsOfShirts, 0, permutationsOfShirts.Count, (x) => MergeResult(combinationOfPeople, x));
                }
            }

            var output = new StringBuilder();
            output.AppendLine(results.Count.ToString());
            foreach (var result in results)
            {
                output.AppendLine(result);
            }

            Console.WriteLine(output.ToString().Trim());
        }

        private static void Comb(int index, int start, int[] array, Action<int[]> action)
        {
            if (index >= people)
            {
                action(array);
            }
            else
                for (int i = start; i < array.Length; i++)
                {
                    array[index] = i;
                    Comb(index + 1, i + 1, array, action);
                }
        }

        private static void PermuteRep(List<char> arr, int start, int n, Action<List<char>> action)
        {
            action(arr);
            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                    if (arr[left] != arr[right])
                    {
                        char oldFirst = arr[left];
                        arr[left] = arr[right];
                        arr[right] = oldFirst;

                        PermuteRep(arr, left + 1, n, action);
                    }
                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                    arr[i] = arr[i + 1];
                arr[n - 1] = firstElement;
            }
        }

        private static void MergeResult(List<int> numbers, List<char> symbols)
        {
            var result = new StringBuilder(numbers.Count + symbols.Count);

            for (int i = 0; i < symbols.Count; i++)
            {
                result.Append(numbers[i]);
                result.Append(symbols[i]);
                result.Append('-');
            }

            result.Length--;

            results.Add(result.ToString());
        }
    }
}