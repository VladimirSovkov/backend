
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckIdentifier;

namespace CheckIdentifierTest
{

    [TestClass]
    public class CheckingForOtherCharacters
    {
        [TestMethod]
        public void CheckForEnglishCharacterOrNumber()
        {
            string inputLine = "Hello123";
            bool outputValue;

            outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(true, outputValue);

            inputLine = "1false";
            outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(true, outputValue);
        }

        [TestMethod]
        public void LetterStringIsServed()
        {
            string inputLine = "hello";
            bool outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(true, outputValue);

        }

        [TestMethod]
        public void ThereAreOtherCharactersInTheLine()
        {
            string inputLine = "false or true";
            bool outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(false, outputValue);

            inputLine = "    ";
            outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(false, outputValue);
        }
    }

    [TestClass]
    public class ID_—heck
    {
        [TestMethod]
        public void TestWithTheCorrectFormOfIdentifier()
        {
            string[] inputString = { "Identificator1" };
            int output;

            output = Program.Main(inputString);

            Assert.AreEqual(0, output);

            inputString[0] = "identificator";
            output = Program.Main(inputString);

            Assert.AreEqual(0, output);

            inputString[0] = "identificato000r";
            output = Program.Main(inputString);

            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void TestWhenEnteringInvalidCharacters()
        {
            string[] inputString = { "Identific*tor1" };
            int output;

            output = Program.Main(inputString);

            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void LineWithSpacesIsGiven()
        {
            string[] inputString = { "Identificator1 false  " };
            int output;

            output = Program.Main(inputString);

            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void First—haracterNumber()
        {
            string[] inputString = { "1dentificator" };
            int output;

            output = Program.Main(inputString);

            Assert.AreEqual(1, output);
        }
    }

    public class —heckForTheNumberOfParameters
    {
        public void LargeNumberOfParameters()
        {
            string[] inputString = { "line", "lineEmpty" };
            int output;

            output = Program.Main(inputString);

            Assert.AreEqual(1, output);
        }

        public void CorrectNumberOfParameters()
        {
            string[] inputString = { "line" };
            int output;

            output = Program.Main(inputString);

            Assert.AreEqual(1, output);
        }

    }
}
