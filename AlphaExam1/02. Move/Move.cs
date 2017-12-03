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


            while(notExit)
            {
                line = Console.ReadLine();
                if (line != "exit")
                {
                    arr = line.Split(' ');
                    steps = int.Parse(arr[0]);
                    direction = arr[1];
                    size = int.Parse(arr[2]);

                    int index = position;

                    for (int i = 0; i < steps; i++)
                    {
                        if (direction == "backwards")
                        {
                            position -= size;

                            if (position > numbers.Length - 1)
                            {
                                position = (position - numbers.Length) % numbers.Length;
                            }
                            if (position < 0)
                            {
                                position = (numbers.Length - position) % numbers.Length;
                            }

                            backward += numbers[index];
                        }
                        else
                        {
                            position += size;

                            if (position > numbers.Length - 1)
                            {
                                position = (position - numbers.Length) % numbers.Length;
                            }
                            if (position < 0)
                            {
                                position = (numbers.Length - position) % numbers.Length;
                            }

                            forward += numbers[index];
                        }
                    }
                }
                else
                {
                    notExit = false;
                }

            }

            Console.WriteLine(forward);
            Console.WriteLine(backward);
        }
    }
}
