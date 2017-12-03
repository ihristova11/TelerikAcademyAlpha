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
            long forward = 0;
            long backward = 0;


            while (notExit)
            {
                line = Console.ReadLine();
                if (line == "exit")
                {
                    notExit = false;
                }
                else
                {
                    arr = line.Split(' ');
                    steps = int.Parse(arr[0]);
                    direction = arr[1];
                    size = int.Parse(arr[2]);
                    
                        if (direction == "forward")
                        {
                        for (int i = 0; i < steps; i++)
                        {
                            position = (position + size) % numbers.Length;

                            forward += numbers[position];
                        }
                    }
                    else
                        {
                        for (int i = 0; i < steps; i++)
                        {
                            position -= size;

                            if (position < 0)
                            {

                                position = numbers.Length + position % (numbers.Length);
                            }

                            if (position >= numbers.Length)
                            {
                                position = position - numbers.Length;
                            }

                            backward += numbers[position];
                        }
                    }

                }

            }

            Console.WriteLine(forward);
            Console.WriteLine(backward);
        }
    }
}