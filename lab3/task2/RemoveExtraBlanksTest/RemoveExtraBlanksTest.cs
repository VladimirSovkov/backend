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
        public void TestingWithDifferentCharactersInAString ()
        {
            string inputString = "   Hello\t\t\t    !@#$%     ^&*(_)(   \t\t\t\t!!!      ";
            string outputString = "Hello !@#$% ^&*(_)( !!!";

            inputString = Program.RemoveExtraSpacesAndTabsInLine(inputString);

            Assert.AreEqual(outputString, inputString);
        }
    }
}
