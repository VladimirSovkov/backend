using System.Collections.Generic;
using System.Linq;
using MyNotes.Data.Interfaces;
using MyNotes.Data.Models;
using System.IO;
using Newtonsoft.Json;

namespace MyNotes.Data.Repositories
{
    public class NotesRepository : INotesRepository
    {
        private static string pathFile;

        public bool IsEmptyFile(string path)
        {
            StreamReader lineFile = new StreamReader(path);
            string line;
            while ((line = lineFile.ReadLine()) != null)
            {
                if (line.Trim() != "")
                {
                    lineFile.Dispose();
                    return false;
                }
            }
            lineFile.Dispose();
            return true;
        }

        public void OpenFile(string path)
        {
            pathFile = path;
            if (!File.Exists(path) || IsEmptyFile(path))
            {
                using StreamWriter fileWithNotes = new StreamWriter(path);
                fileWithNotes.WriteLine("[]");
            }
        }

        public void AddNote(Note note)
        {
            List<Note> listOfNotes = GetAllNotes().ToList();
            listOfNotes.Add(note);
            
            string line = JsonConvert.SerializeObject(listOfNotes);
            File.WriteAllText(pathFile, line);
        }

        public IEnumerable<Note> GetAllNotes()
        {
            List<Note> listOfNotes = new List<Note>();
            
            using (StreamReader NoteRepository = new StreamReader(pathFile))
            {
                string AllText = NoteRepository.ReadToEnd();
                listOfNotes = JsonConvert.DeserializeObject<List<Note>>(AllText);
            }

            return listOfNotes;
        }
    }
}
