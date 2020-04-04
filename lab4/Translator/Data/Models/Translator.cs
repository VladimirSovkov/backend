using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Translate.Data.Models
{
    public class DictionaryFile
    {
        public Dictionary<string, string> vocabulary;

        private bool IsEng(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'z')
                {
                    return true;
                }
            }
            return false;
        }

        public void CreatDictionary(string nameFile)
        {
            vocabulary = new Dictionary<string, string>();
            StreamReader inputFile = new StreamReader(nameFile);
            string line;
            char[] symbol = { '=' };

            while ((line = inputFile.ReadLine()) != null)
            {
                line = line.ToLower();
                string[] KeyAndValue = line.Split(symbol);
                if (KeyAndValue.Length != 2)
                {
                    throw new Exception("translation file is incorrectly filled (engWord = rusWord)");
                }

                KeyAndValue[0] = KeyAndValue[0].Trim();
                KeyAndValue[1] = KeyAndValue[1].Trim();
                if (!IsEng(KeyAndValue[0]))
                {
                    throw new Exception("the first word in the line should be in English (engWord = rusWord)");
                }

                vocabulary.Add(KeyAndValue[0], KeyAndValue[1]);
            }
        }

        private string GetTranslationFromEngToRus(string word)
        {
            string value = "";
            if (vocabulary.TryGetValue(word, out value))
            {
                return value;
            }

            return "";
        }

        private string GetTranslationFromRusToEng(string word)
        {
            foreach (string keyWord in vocabulary.Keys)
            {
                if (vocabulary[keyWord] == word)
                {
                    return keyWord;
                }
            }

            return "";
        }

        public string GetWordTranslation(string word)
        {
            word = word.ToLower();
            word = word.Trim();
            if (IsEng(word) == true)
            {
                return GetTranslationFromEngToRus(word);
            }
            else
            {
                return GetTranslationFromRusToEng(word);
            }
        }

    }
}
