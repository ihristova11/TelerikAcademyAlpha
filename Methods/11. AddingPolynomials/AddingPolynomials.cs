namespace _11.AddingPolynomials
{
    using System;
    using System.Linq;

    class AddingPolynomials
    {
        static void Main()
        {
            int len = int.Parse(Console.ReadLine());
            int[] firstExpCoeff = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondExpCoeff = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(AddPolynomials(len, firstExpCoeff, secondExpCoeff));
        }

        public static string AddPolynomials(int len, int[] firstExpCoeff, int[] secondExpCoeff)
        {
            var result = new int[len];
            for (int i = 0; i < len; i++)
            {
                result[i] += firstExpCoeff[i] + secondExpCoeff[i];
            }

            return string.Join(" ", result);
        }
    }
}
