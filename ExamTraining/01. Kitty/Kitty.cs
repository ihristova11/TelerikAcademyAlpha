namespace _01.Kitty
{
    using System;
    using System.Linq;
    using System.Text;

    class Kitty
    {
        public static int[] directions;
        public static StringBuilder path;

        static void Main()
        {
            // reading the path for the kitty
            path = new StringBuilder(Console.ReadLine());
            directions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();          
        }
        //method for getting the direction
        static void GetDirection()
        {
            int position = 0; //holds the position in the path
            int souls = 0; //holds the collected souls
            int food = 0; //holds the collected food
            int deadlocks = 0; //holds the number of deadlocks
            for (int direction = 0; direction < directions.Length; direction++)
            {
                int move = directions[direction]; //current direction

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
