using System;

namespace print_args
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = args.Length;

            if (amount == 0)
            {
                Console.Write("No parameters were specified!");
            }
            else
            {
                Console.Write("Number of arguments: " + amount + '\n');
                Console.Write("Arguments: ");
                for (int i = 0; i < amount; i++)
                {
                    Console.Write(args[i] + ' ');
                }
            }
        }
    }
}
