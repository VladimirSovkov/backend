using System;

namespace CheckIdentifier
{
    public class Program
    {
        public static bool IsAnEnglishLetter(char symbol)
        {
            if ((symbol >= 'A' && symbol <= 'Z') ||
                (symbol >= 'a' && symbol <= 'z'))
            {
                return true;
            }

            return false;
        }
         static bool IsNumber(char symbol)
        {
            if (symbol >= '0' && symbol <= '9')
            {
                return true;
            }

            return false;
        }

        public static bool LineConsistsOfLettersAndNumbers(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!(IsAnEnglishLetter(inputString[i]) || IsNumber(inputString[i])))
                {
                    return false;
                }
            }

            return true;
        }

        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("no");
                Console.WriteLine("invalid number of parameters");
                Console.WriteLine("identifier");
                return 1;
            }

            string inputString = args[0];

            if (String.IsNullOrEmpty(inputString))
            {
                Console.WriteLine("no");
                Console.WriteLine("empty line passed");
                return 1;
            }

            if (!IsAnEnglishLetter(inputString[0]))
            {
                Console.WriteLine("no");
                Console.WriteLine("first character must be a letter");
                return 1;
            }

            if (!LineConsistsOfLettersAndNumbers(inputString))
            {
                Console.WriteLine("no");
                Console.WriteLine("the identifier should consist only of letters and numbers");
                return 1;
            }

            Console.WriteLine("yes");
            return 0;
        }
    }
}
