using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveExtraBlanks;

namespace RemoveExtraBlanksTest
{
    [TestClass]
    public class RemoveExtraBlanksTest
    {
        [TestMethod]
        public void TestRemoveExtraSpaces()
        {
            string inputString = "   Hello\t\t\t    world   \t\t\t\t!!!      ";
            string outputString = "Hello world !!!";

            inputString = Program.RemoveExtraSpacesAndTabsInLine(inputString);

            Assert.AreEqual(outputString, inputString);
        }

        [TestMethod]
        public void OtherSpecialCharacters()
        {
            string inputString = "   Hello\t\t\t    !@#$%     ^&*(_)(   \t\t\t\t!!!     ";
            string outputString = "Hello !@#$% ^&*(_)( !!!";

            inputString = Program.RemoveExtraSpacesAndTabsInLine(inputString);

            Assert.AreEqual(outputString, inputString);
        }
    }

    [TestClass]
    public class ÑheckForParameters
    {
        [TestMethod]
        public void CheckForTheNumberOfParameters()
        {
            string[] input = { "input.txt", "input.txt", "input.txt" };
            int output;

            output = Program.Main(input);

            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void FileNameIsAnEmptyString()
        {
            string[] input = { "", "" };
            int output;

            output = Program.Main(input);

            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void TheOutputFileIsWrittenAsAnEmptyLine()
        {
            string[] input = { "input.txt", "" };
            int output;

            output = Program.Main(input);

            Assert.AreEqual(1, output);
        }


    }
}
