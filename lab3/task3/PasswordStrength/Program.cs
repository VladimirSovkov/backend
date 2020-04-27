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

        public static int GetCountOfDigits(string line)
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

        static int GetCountUpperCaseCharacters(string line)
        {
            int upperCaseCharacters = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= 'A' && line[i] <= 'Z')
                {
                    upperCaseCharacters++;
                }
            }
            return upperCaseCharacters;
        }

       public static int GetStrengthForUpperLetters(string line)
        {
            int upperCaseCharacters = GetCountUpperCaseCharacters(line);
            int countCharacters = line.Length;
            if (upperCaseCharacters == 0)
            {
                return upperCaseCharacters;
            }
            else
            { 
                return (countCharacters - upperCaseCharacters) * 2; 
            }
        }

        static int GetCountLowerCaseCharacter(string line)
        {
            int numberСharactersInLowerCase = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= 'a' && line[i] <= 'z')
                {
                    numberСharactersInLowerCase++;
                }
            }
            return numberСharactersInLowerCase;
        }
        public static int GetStrengthForLowerLetters(string line)
        {
            int countCharacters = line.Length;
            int numberСharactersInLowerCase = GetCountLowerCaseCharacter(line);
            if (numberСharactersInLowerCase == 0)
            {
                return numberСharactersInLowerCase;
            }
            else 
            {
                return (countCharacters - numberСharactersInLowerCase) * 2;
            }
        }

        public static int GetStrengthOnlyForLetters(string line)
        {
            int countCharacters = line.Length;
            int countNumbers = GetCountOfDigits(line);
            if (countNumbers == 0)
            {
                return countCharacters;
            }
            else
            {
                return 0;
            }
        }

        public static int GetStrengthOnlyForNumbers(string line)
        {
            int countCharacters = line.Length;
            int countNumbers = GetCountOfDigits(line);
            if (countCharacters == countNumbers)
            {
                return countCharacters;
            }
            else 
            {
                return 0;
            }
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
            int rating = 4 * line.Length;
            rating += 4 * GetCountOfDigits(line);
            rating += GetStrengthForUpperLetters(line);
            rating += GetStrengthForLowerLetters(line);
            rating -= GetStrengthOnlyForLetters(line);
            rating -= GetStrengthOnlyForNumbers(line);
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
