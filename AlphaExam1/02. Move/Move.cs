namespace _02.Move
{
    using System;
    using System.Linq;

    class Move
    {
        static void Main()
        {
            //reading input
            int position = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string direction = string.Empty;
            int size;
            int steps;
            bool notExit = true;
            string[] arr;
            string line = string.Empty;
            long sum = 0;


            while(notExit)
            {
                line = Console.ReadLine();
                if (line != "exit")
                {
                    arr = line.Split(' ');
                    steps = int.Parse(arr[0]);
                    direction = arr[1];
                    size = int.Parse(arr[2]);

                    if(direction == "backwards")
                    {
                        size *= -1;
                    }

                    int index = position;

                    while(index != position + steps * size)
                    {
                        sum += numbers[index];
                        index += size;
                    }
                }
                else
                {
                    notExit = false;
                }

            }
        }
    }
}
