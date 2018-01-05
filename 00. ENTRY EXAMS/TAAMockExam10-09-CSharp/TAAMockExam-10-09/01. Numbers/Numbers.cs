using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            string digit = "";
            string command;
            string[] splitCommand;
            BigInteger result;
            List<string> inputCommandsArray = new List<string>();
            StringBuilder outputResult = new StringBuilder();
            StringBuilder reversedString;

            while (true)
            {
                string input = Console.ReadLine();

                inputCommandsArray.Add(input);

                if (input == "end")
                {
                    break;
                }
            }

            for (int index = 0; index < inputCommandsArray.Count; index++)
            {
                command = inputCommandsArray[index];

                if (char.IsDigit(command.LastOrDefault()))
                {
                    splitCommand = command.Split(' ');

                    command = splitCommand[0];
                    digit = splitCommand[1];
                }

                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "set":
                        if (outputResult.Length > 0)
                        {
                            outputResult.Clear();
                            outputResult.Append(digit);
                        }
                        else
                        {
                            outputResult.Append(digit);
                        }
                        break;

                    case "front-add":
                        outputResult.Insert(0, digit);
                        break;

                    case "front-remove":

                        if (char.IsDigit(outputResult.ToString().FirstOrDefault()))
                        {
                            outputResult.Remove(0, 1);
                        }

                        break;

                    case "back-add":
                        outputResult.Append(digit);

                        break;

                    case "back-remove":
                        if (char.IsDigit(outputResult.ToString().LastOrDefault()))
                        {
                            outputResult.Remove(outputResult.Length - 1, 1);
                        }
                        break;

                    case "reverse":
                        reversedString = Reverse(outputResult);
                        outputResult.Clear();
                        outputResult.Append(reversedString);
                        break;

                    case "print":

                        if (BigInteger.TryParse(outputResult.ToString(), out result))
                        {
                            Console.WriteLine(outputResult.ToString());
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        public static StringBuilder Reverse(StringBuilder s)
        {
            StringBuilder reversedString = new StringBuilder();

            for (int index = s.Length - 1; index >= 0; index--)
            {
                reversedString.Append(s[index]);
            }

            return reversedString;
        }

    }
}

