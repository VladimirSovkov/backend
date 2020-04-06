using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;
using Translate.Data.Models;
using System.Collections.Generic;

namespace TranslatorTest
{
    [TestClass]
    public class CreatingDictionaryByAddingWordsFromTextFile
    {
        [TestMethod]
        public void CheckingTheCorrectnessOfTheDictionaryEntry()
        {
            Vocabulary createdDictionaryFromFile = new Vocabulary("..\\..\\..\\testData\\dictionary.txt");
            Dictionary<string, string> OutputDictionary = new Dictionary<string, string>
            {
                ["red"] = "�������",
                ["apple"] = "������",
                ["cat"] = "���",
                ["number"] = "�����",
                ["red square"] = "������� �������",
                ["word"] = "�����" 
            };

            CollectionAssert.AreEquivalent(OutputDictionary, createdDictionaryFromFile.vocabulary);
        }

        [TestMethod]
        public void EmptyFile()
        {
            Vocabulary createdDictionaryFromFile = new Vocabulary("..\\..\\..\\testData\\EmptyFile.txt");
            Dictionary<string, string> Aa = new Dictionary<string, string>();

            CollectionAssert.AreEquivalent(Aa, createdDictionaryFromFile.vocabulary);
        }
    }

    [TestClass]
    public class CheckTranslationSearchWordsInTheDictionary
    {
        Vocabulary createdDictionaryFromFile = new Vocabulary("..\\..\\..\\testData\\dictionary.txt");

        [TestMethod]

        public void SearchForTranslationFromEngIntoRus()
        {
            string translatedWord = createdDictionaryFromFile.GetWordTranslation("apple");

            Assert.AreEqual("������", translatedWord);
        }

        [TestMethod]
        public void SearchForTranslationFromRusIntoEng()
        {
            string translatedWord = createdDictionaryFromFile.GetWordTranslation("������� �������");

            Assert.AreEqual("red square", translatedWord);
        }

        [TestMethod]
        public void SearchForWordThatIsNotInTheDictionary()
        {
            string translatedWord = createdDictionaryFromFile.GetWordTranslation("Not");

            Assert.AreEqual(null, translatedWord);
        }
    }
}
