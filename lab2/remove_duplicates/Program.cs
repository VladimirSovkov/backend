using System;

namespace remove_duplicates
{
    class Program
    {
        static string DeleteDuplicateCharacters(string line)
        {
            int index = 0;
            for (int i = 0; i < line.Length; i++)
            {
                index = line.IndexOf(line[i], i + 1);

                while (index != -1)
                {
                    line = line.Remove(index, 1);
                    index = line.IndexOf(line[i], i + 1);
                }
            }

            return line;
        }

        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.Write("Incorrect number of arguments! " + "\n" + "Usage remove_duplicates.exe <input string>");
            }
            else
            {
                Console.Write(DeleteDuplicateCharacters(args[0]));
            }
        }
    }
}
