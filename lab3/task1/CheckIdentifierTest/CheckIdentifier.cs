
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckIdentifier;

namespace CheckIdentifierTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EnglishCharacterTest()
        {
            char symbol = 'H';
            bool output;

            output = Program.IsAnEnglishLetter(symbol);

            Assert.AreEqual(true, output);

            symbol = 'h';
            output = Program.IsAnEnglishLetter(symbol);

            Assert.AreEqual(true, output);

            symbol = '5';
            output = Program.IsAnEnglishLetter(symbol);

            Assert.AreEqual(false, output);

            symbol = ' ';
            output = Program.IsAnEnglishLetter(symbol);
        }

        [TestMethod]
        public void CheckForEnglishCharacterOrNumber()
        {
            string inputLine = "Hello123";
            bool outputValue;

            outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(true, outputValue);

            inputLine = "hello";
            outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(true, outputValue);

            inputLine = "1false";
            outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(true, outputValue);

            inputLine = "false or true";
            outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(false, outputValue);

            inputLine = "    ";
            outputValue = Program.LineConsistsOfLettersAndNumbers(inputLine);

            Assert.AreEqual(false, outputValue);
        }

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

            inputString[0] =  "identificato000r" ;
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
}
