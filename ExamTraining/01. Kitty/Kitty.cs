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
            StringBuilder path = Console.ReadLine();
            int[] directions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int position = 0;
            int souls = 0;
            int food = 0;
            int deadlocks = 0;
            for (int direction = 0; direction < directions.Length; direction++)
            {
                switch(path[direction])
                {
                    case '@':
                        souls++;
                        path[direction] = 'v';
                        break;
                    case 'x': break;
                        if (position % 2 == 0)
                        {
                            if(souls > 0)
                            {
                                souls--;
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
                            if(food > 0 )
                            {
                                food--;
                                path[position] = '*';
                            }
                            else
                            {
                                Console.WriteLine("You are deadlocked, you greedy kitty!");
                                Console.WriteLine("Jumps before deadlock: {0}", direction);
                            }
                        }
                    case '*': break;
                }
                position = directions[direction];
            }

        }
    }
}
