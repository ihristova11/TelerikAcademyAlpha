using System;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] elements = new int[length];
        int maxCount = 0;
        int currentCount = 1;
        int sequenceStart = 0;
        for (int index = 0; index < length; index++)
        {
            elements[index] = int.Parse(Console.ReadLine());
            if (index != 0)
            {
                if (elements[index] == elements[index - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    sequenceStart = index + 1 - maxCount;
                }
            }
        }
        
            Console.WriteLine("{0} ", maxCount);
    }
}