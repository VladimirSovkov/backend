using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordStrength;

namespace PasswordStrengthTest
{
    [TestClass]
    public class ÑheckingForValidCharacters
    {
        [TestMethod]
        public void TestWithCorrectString()
        {
            string inputLine = "Abc123";
            bool output = PasswordStrength.PasswordStrength.IsLettersAndChars(inputLine);

            Assert.AreEqual(true, output);
        }

        public void TestWithInCorrectString()
        {
            string inputLine = "Abc123!@#";
            bool output = PasswordStrength.PasswordStrength.IsLettersAndChars(inputLine);

            Assert.AreEqual(false, output);
        }
    }

    [TestClass]
    public class CheckingGetCalculationOfNumbers
    {
        [TestMethod]
        public void GetCountNumbers()
        {
            string line = "a1b2c345";
            int count = PasswordStrength.PasswordStrength.GetCountOfDigits(line);

            Assert.AreEqual(5, count);
        }
    }

    [TestClass]
    public class CheckingGetStrengthForUpperLetters
    {
        [TestMethod]
        public void StringWhithoutUpperLetters()
        {
            string line = "password";
            int count = PasswordStrength.PasswordStrength.GetStrengthForUpperLetters(line);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void StringWithUpperLetters()
        {
            string line = "PassWord";
            int count = PasswordStrength.PasswordStrength.GetStrengthForUpperLetters(line);

            Assert.AreEqual(12, count);
        }
    }

    [TestClass]
    public class CheckingGetStrengthForLowerLetters
    {
        [TestMethod]
        public void StringWithoutLowerLetters()
        {
            string line = "PASSWORD";
            int count = PasswordStrength.PasswordStrength.GetStrengthForLowerLetters(line);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void StringWithLowerLetters()
        {
            string line = "PassWord";
            int count = PasswordStrength.PasswordStrength.GetStrengthForLowerLetters(line);

            Assert.AreEqual(4, count);
        }
    }

    [TestClass]
    public class CheckingGetStrengthOnlyForNumbers
    {
        [TestMethod]
        public void StringOnlyNumbers()
        {
            string line = "12345";
            int count = PasswordStrength.PasswordStrength.GetStrengthOnlyForNumbers(line);

            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void StringOnlyLetters()
        {
            string line = "password";
            int count = PasswordStrength.PasswordStrength.GetStrengthOnlyForNumbers(line);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void StringWithLettersAndNumbers()
        {
            string line = "Password123";
            int count = PasswordStrength.PasswordStrength.GetStrengthOnlyForNumbers(line);
            
            Assert.AreEqual(0, count);
        }
    }

    [TestClass]
    public class CheckingGetStrengthOnlyForLetters
    {
        [TestMethod]
        public void StringOnlyLetters()
        {
            string line = "password";
            int count = PasswordStrength.PasswordStrength.GetStrengthOnlyForLetters(line);

            Assert.AreEqual(8, count);
        }

        [TestMethod]
        public void StringOnlyNumbers()
        {
            string line = "12345";
            int count = PasswordStrength.PasswordStrength.GetStrengthOnlyForLetters(line);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void StringWithLettersAndNumbers()
        {
            string line = "password123";
            int count = PasswordStrength.PasswordStrength.GetStrengthOnlyForLetters(line);

            Assert.AreEqual(0, count);
        }
    }

    [TestClass]
    public class ÑheckingForCountingRepeatedCharacters
    {
        [TestMethod]
        public void StringOfDuplicateCharacters()
        {
            string inputLine = "aaabcad";
            int outputNumber = PasswordStrength.PasswordStrength.NumberOfRepeatedCharacters(inputLine);

            Assert.AreEqual(4, outputNumber);
        }

        [TestMethod]
        public void StringWithoutDuplicateCharacters()
        {
            string inputLine = "abcd";
            int outputNumber = PasswordStrength.PasswordStrength.NumberOfRepeatedCharacters(inputLine);

            Assert.AreEqual(0, outputNumber);
        }
    }

    [TestClass]
    public class ÑheckingPasswordScoreCalculation
    {
        [TestMethod]
        public void PasswordWithSmallLettersOnly()
        {
            string inputLine = "password";
            int outputNumber = PasswordStrength.PasswordStrength.PasswordComplexityRating(inputLine);

            Assert.AreEqual(22, outputNumber);

        }

        [TestMethod]
        public void PasswordConsistsOnlyOfCapitalLetters()
        {
            string inputLine = "PASSWORD";
            int outputNumber = PasswordStrength.PasswordStrength.PasswordComplexityRating(inputLine);

            Assert.AreEqual(22, outputNumber);
        }

        [TestMethod]
        public void PasswordConsistsOfNumbersOnly()
        {
            string inputLine = "12345678";
            int outputNumber = PasswordStrength.PasswordStrength.PasswordComplexityRating(inputLine);

            Assert.AreEqual(56, outputNumber);
        }

        [TestMethod]
        public void PasswordWithLargeAndSmallCharacters()
        {
            string inputLine = "PassworD";
            int outputNumber = PasswordStrength.PasswordStrength.PasswordComplexityRating(inputLine);

            Assert.AreEqual(38, outputNumber);
        }

        [TestMethod]
        public void PasswordWithCapitalAndSmallLettersWithNumbers()
        {
            string inputLine = "PassworD123";
            int outputNumber = PasswordStrength.PasswordStrength.PasswordComplexityRating(inputLine);

            Assert.AreEqual(82, outputNumber);
        }
    }

    [TestClass]
    public class ÑheckingTheOperationOfProgramItSelf
    {
        [TestMethod]
        public void PassedAnIncorrectNumberOfParameters()
        {
            string[] input = { "password", "emptyLine" };
            int output = PasswordStrength.PasswordStrength.Main(input);

            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void PassedAStringWithInvalidCharacter()
        {
            string[] input = { "pa$$word" };
            int output = PasswordStrength.PasswordStrength.Main(input);

            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void PassedTheCorrectPassword()
        {
            string[] input = { "PassworD123" };
            int output = PasswordStrength.PasswordStrength.Main(input);

            Assert.AreEqual(0, output);
        }
    }
}
