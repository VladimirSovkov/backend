using System;
using  System.IO;

namespace RemoveExtraBlanks
{
    public class Program
    {

        public static string RemoveExtraSpacesAndTabsInLine(string inputString)
        {
            inputString = inputString.Trim();

            bool isSpace = true;
            for (int i = 0; i < inputString.Length; )
            {
                if (isSpace && inputString[i] == ' ')
                {
                    inputString = inputString.Remove(i, 1);
                }
                else
                {
                    isSpace = false;

                    if(inputString[i] == '\t')
                    {
                        inputString = inputString.Remove(i, 1);
                    }
                    else
                    {
                        if (inputString[i] == ' ')
                        {
                            isSpace = true;
                        }

                        i++;
                    }
                }
            }

            return inputString;
        }

        public static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("invalid number of parameters passed");
                Console.WriteLine("<input.txt> <output.txt>");
                return 1;
            }

            if(!File.Exists(args[0]))
            {
                Console.WriteLine("This file: \"" + args[0] + "\" does not exist.");
                return 1;
            }

            StreamReader inputFile = new StreamReader(args[0], false);
            StreamWriter outputFile = new StreamWriter(args[1]);

            string line;

            while ((line = inputFile.ReadLine()) != null)
            {
                line = RemoveExtraSpacesAndTabsInLine(line);
                outputFile.WriteLine(line);
            }

            inputFile.Close();
            outputFile.Close();

            return 0;
        }
    }
}
