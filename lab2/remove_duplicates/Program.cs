using System;

namespace remove_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.Write("Incorrect number of arguments! " + "\n" + "Usage remove_duplicates.exe <input string>");
            }
            else
            {
                string transmittedString = args[0];
                int index = 0;
                for (int i = 0; i < transmittedString.Length; i++)
                {
                    index = transmittedString.IndexOf(transmittedString[i], i + 1);

                    while (index != -1)
                    {
                        transmittedString = transmittedString.Remove(index, 1);
                        index = transmittedString.IndexOf(transmittedString[i], i + 1);
                    }
                }

                Console.Write(transmittedString);
            }
        }
    }
}
