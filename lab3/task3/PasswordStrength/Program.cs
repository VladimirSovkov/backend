using System;
using System.Collections.Generic;

namespace PasswordStrength
{
    public class PasswordStrength
    {
        public static bool IsLettersAndChars(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (!(line[i] >= 'A' && line[i] <= 'Z'))
                {
                    if (!(line[i] >= 'a' && line[i] <= 'z'))
                    {
                        if (!(line[i] >= '0' && line[i] <= '9'))
                        {
                            return false;
                        }
                    }

                }
            }
            return true;
        }

        static int NumberOfDigits(string line)
        {
            int countDigits = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= '0' && line[i] <= '9')
                {
                    countDigits++;
                }
            }
            return countDigits;
        }

        static int UpperCaseCharacters(string line)
        {
            int countSymbol = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >='A' && line[i] <= 'Z' )
                {
                    countSymbol++;
                }
            }

            return countSymbol;
        }

        static int NumberOfCharactersInLowerCase(string line)
        {
            int countSymbol = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= 'a' && line[i] <= 'z')
                {
                    countSymbol++;
                }
            }

            return countSymbol;
        }

        public static int NumberOfRepeatedCharacters(string line)
        {
            int numberOfRepetitions = 0;
            Dictionary<char, int> readСharacters = new Dictionary<char, int>();

            for (int i = 0; i < line.Length; i++)
            {
                if (readСharacters.ContainsKey(line[i]))
                {
                    readСharacters[line[i]]++;
                }
                else
                {
                    readСharacters[line[i]] = 1;
                }
            }
            foreach (var item in readСharacters)
            {
                if (item.Value > 1)
                {
                    numberOfRepetitions += item.Value;
                }
            }
            

            return numberOfRepetitions;

        }

        public static int PasswordComplexityRating(string line)
        {
            int rating = 0;
            int countCharecters = line.Length;
            int countNumber = NumberOfDigits(line);
            rating = 4 * countCharecters;
            rating += 4 * NumberOfDigits(line);
            int numberOfCapitalLetters = UpperCaseCharacters(line);
            if (numberOfCapitalLetters > 0)
            {
                rating += (countCharecters - numberOfCapitalLetters) * 2;
            }
            int numberOfSmallLetters = NumberOfCharactersInLowerCase(line);

            if (numberOfSmallLetters > 0)
            {
                rating += (countCharecters - numberOfSmallLetters) * 2;
            }

            if (countNumber == 0)
            {
                rating -= countCharecters;
            }

            if (countCharecters == countNumber)
            {
                rating -= countCharecters;
            }

            rating -= NumberOfRepeatedCharacters(line);

            return rating;
        }


        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("invalid number of parameters passed");
                Console.WriteLine("<password>");
                return 1;
            }
            if (IsLettersAndChars(args[0]) == false)
            {
                Console.WriteLine("Password can only consist of letters and characters");
                return 1;
            }

            Console.WriteLine(PasswordComplexityRating(args[0]));

            return 0;
        }
    }
}
