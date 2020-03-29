using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordStrength;

namespace PasswordStrengthTest
{
    [TestClass]
    public class —heckingForValidCharacters
    {
        [TestMethod]
        public void TestingWithInvalidCharacters()
        {
            string inputLine = "Abc123";
            bool output = PasswordStrength.PasswordStrength.IsLettersAndChars(inputLine);

            Assert.AreEqual(true, output);
        }


        public void TheLineContainsInvalid—haracters()
        {
            string inputLine = "Abc123!@#";
            bool output = PasswordStrength.PasswordStrength.IsLettersAndChars(inputLine);

            Assert.AreEqual(false, output);
        }

    }

    [TestClass]
    public class —heckingPasswordScoreCalculation
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
    public class —heckingForCountingRepeatedCharacters
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
    public class —heckingTheOperationOfTheProgramItself
    {
        [TestMethod]
        public void PassedAnIncorrectNumberOfParameters()
        {
            string[] input = {"password", "emptyLine"};
            int output = PasswordStrength.PasswordStrength.Main(input);

            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void PassedAStringWithInvalidCharacter()
        {
            string[] input = { "pa$$word"};
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
