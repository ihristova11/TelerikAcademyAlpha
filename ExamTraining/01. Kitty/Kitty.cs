namespace _01.Kitty
{
    using System;
    using System.Linq;
    using System.Text;

    class Kitty
    {
        static void Main()
        {
            // reading the path for the kitty
            StringBuilder path = new StringBuilder(Console.ReadLine());
            int[] directions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int position = 0; //holds the position in the path
            int souls = 0;
            int food = 0;
            int deadlocks = 0;
            for (int direction = 0; direction < directions.Length; direction++)
            {
                int move = directions[direction];
                
                while (position > path.Length - 1)
                {
                    position -= path.Length;
                }

                while (position < 0)
                {
                    position += path.Length;
                }

                switch (path[direction])
                {
                    case '@':
                        souls++;
                        path[direction] = 'v';
                        break;
                    case 'x':
                        if (position % 2 == 0)
                        {
                            if (souls > 0)
                            {
                                souls--;
                                deadlocks++;
                                path[position] = '@';
                            }
                            else
                            {
                                Console.WriteLine("You are deadlocked, you greedy kitty!");
                                Console.WriteLine("Jumps before deadlock: {0}", direction);
                            }
                        }
                        else
                        {
                            if (food > 0)
                            {
                                food--;
                                deadlocks++;
                                path[position] = '*';
                            }
                            else
                            {
                                Console.WriteLine("You are deadlocked, you greedy kitty!");
                                Console.WriteLine("Jumps before deadlock: {0}", direction);
                            }
                        }
                        break;

                    case '*':
                        food++;
                        path[position] = 'v';
                        break;
                }
            }
            Console.WriteLine("Coder souls collected: {0}", souls);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", deadlocks);

        }
    }
}
