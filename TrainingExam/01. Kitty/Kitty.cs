namespace _01.Kitty
{
    using System;
    using System.Linq;
    using System.Text;

    class Kitty
    {
        static int position = 0;
        static int direction = 0;
        static int souls = 0;
        static int deadlocks = 0;
        static int food = 0;
        static int[] directions;
        static StringBuilder path;
        static void Main()
        {
            path = new StringBuilder(Console.ReadLine());
            directions = ("0 " + Console.ReadLine())
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            CheckPosition();
        }

        public static void CheckPosition()
        {
            for (int direction = 0; direction < directions.Length; direction++)
            {
                int move = directions[direction];
                if (move > 0) //right
                {
                    position += move;
                    while (position > path.Length - 1)
                    {
                        position -= path.Length;
                    }
                }

                if (move < 0) //left
                {
                    position += move;
                    while (position < 0)
                    {
                        position += path.Length;
                    }
                }

                switch (path[position])
                {
                    case '@':
                        souls++;
                        path[position] = 'v';
                        break;
                    case '*':
                        food++;
                        path[position] = 'v';
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
                                return;
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
                                return;
                            }
                        }
                        break;
                    default: break;
                }
            }

            Console.WriteLine("Coder souls collected: {0}", souls);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", deadlocks);
        }
    }
}