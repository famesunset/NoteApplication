using System.Collections.Generic;
using NoteApplication.Data_Access_Layer;
using NoteApplication.Models;

namespace NoteApplication.Data_Access_Layer
{
    public class NotesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NoteContext>
    {
        protected override void Seed(NoteContext context)
        {
            var notes = new List<Note>
            {
                new Note(id: 1, text: "Note1"),
                new Note(id: 2, text: "Note2"),
                new Note(id: 3,text: "Note3"),
                new Note(id: 4,text: "Note4"),
                new Note(id: 5,text: "Note5"),
                new Note(id: 6,text: "Note6"),
                new Note(id: 7,text: "Note7")
            };
            notes.ForEach(s => context.Notes.Add(s));
            context.SaveChanges();
        }
    }
}