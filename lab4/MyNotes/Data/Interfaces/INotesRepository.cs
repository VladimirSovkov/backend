using System.Collections.Generic;
using MyNotes.Data.Models;

namespace MyNotes.Data.Interfaces
{
    public interface INotesRepository
    {
        IEnumerable<Note> GetAllNotes();
        void AddNote(Note note);
    }
}
