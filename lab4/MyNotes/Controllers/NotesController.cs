
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyNotes.Data.Interfaces;
using MyNotes.Data.Models;
using MyNotes.Data.Repositories;

namespace MyNotes.Controllers
{
    public class NotesController : Controller
    {
        private readonly INotesRepository _iNotesRepository;

        public NotesController(INotesRepository iNotesRepository)
        {
            _iNotesRepository = iNotesRepository;
            NotesRepository notesRepository = new NotesRepository();
            
            notesRepository.OpenFile("CollectionOfNotes\\NoteRepository.json");
        }   

        [HttpGet("notes/list")]
        public JsonResult ListOutput()
        {
            var notes = _iNotesRepository.GetAllNotes();
            return Json(notes);
        }

        [HttpPost("note/add")]
        public async Task<StatusCodeResult> Add()
        {
            Note note = new Note();
            using (StreamReader inputStream = new StreamReader(Request.Body, Encoding.UTF8))
            { 
                note.Text = await inputStream.ReadToEndAsync();
            }
            _iNotesRepository.AddNote(note);
            return Ok();
        }


        public ViewResult List()
        {
            return View();
        }
    }
}
