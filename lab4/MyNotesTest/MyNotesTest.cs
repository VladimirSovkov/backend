using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyNotes.Data.Models;
using MyNotes.Data.Repositories;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyNotesTest
{
    [TestClass]
    public class ÑheckingForEmptyFile
    {
        private NotesRepository notesRepository = new NotesRepository();

        [TestMethod]
        public void EmptyFileServed()
        {
            string path = "..\\..\\..\\testData\\EmptyFile.txt";
            bool output = notesRepository.IsEmptyFile(path);

            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void FileFillede()
        {
            string path = "..\\..\\..\\testData\\NotEmptyFile.txt";
            bool output = notesRepository.IsEmptyFile(path);

            Assert.AreEqual(false, output);
        }
    }

    [TestClass]
    public class FileOpenCheck
    {
        private NotesRepository notesRepository = new NotesRepository();

        [TestMethod]
        public void ÑheckForFile()
        {
            string path = "..\\..\\..\\testData\\NotEmptyFile.txt";
            notesRepository.OpenFile(path);
            bool output = File.Exists(path);

            Assert.AreEqual(true, output);
            
        }

        [TestMethod]
        public void VerificationOfTheCreationfOthePreparedFile()
        {
            string path = "..\\..\\..\\testData\\File.txt";
            File.Delete(path);
            notesRepository.OpenFile(path);
            bool output = File.Exists(path);

            Assert.AreEqual(true, output);
        }
    }

    [TestClass]
    public class CheckForAddingText
    {
        private NotesRepository repositoryWithoutAddedNote = new NotesRepository();

        [TestMethod]
        public void AddNotesToMemory()
        {
            File.Delete("..\\..\\..\\testData\\FileWithoutAddedItem.json");
            repositoryWithoutAddedNote.OpenFile("..\\..\\..\\testData\\FileWithoutAddedItem.json");
            Note note = new Note();
            note.Text = "ñòðîêà áåç ñìûñëà";

            List<Note> manualAddList = new List<Note> { note };

            repositoryWithoutAddedNote.AddNote(note);
            List<Note> listWithAddViaFunction = repositoryWithoutAddedNote.GetAllNotes().ToList<Note>();
           
            Assert.AreEqual(manualAddList.Count(), listWithAddViaFunction.Count());
            Assert.AreEqual(manualAddList[0].Text, listWithAddViaFunction[0].Text);
        }
    }

    [TestClass]
    public class CheckForViewingAllNotes
    {
        private NotesRepository notesRepository = new NotesRepository();

        [TestMethod]
        public void ShowEmptyList()
        {
            List<Note> sampleEmptyList = new List<Note>();

            notesRepository.OpenFile("..\\..\\..\\testData\\FileWithoutNotes.txt");
            List<Note> outEmptyList = notesRepository.GetAllNotes().ToList();

            CollectionAssert.AreEquivalent(sampleEmptyList, outEmptyList);
        }

        [TestMethod]
        public void VerificationOfTheOutputOfAllNotes()
        {
            Note note = new Note();
            note.Text = "ñòðîêà áåç ñìûñëà";
            List<Note> sampleEmptyList = new List<Note> {note};

            notesRepository.OpenFile("..\\..\\..\\testData\\SingleNoteFile.json");
            List<Note> outEmptyList = notesRepository.GetAllNotes().ToList();

            Assert.AreEqual(sampleEmptyList.Count(), outEmptyList.Count());
            Assert.AreEqual(sampleEmptyList[0].Text, outEmptyList[0].Text);
        }
    }
}
