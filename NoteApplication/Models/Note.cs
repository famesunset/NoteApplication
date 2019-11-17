using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoteApplication.Models
{
    [Table("notesdetales")]
    public class Note
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Text { get; set; }

        public Note(int id, string text)
        {
            this.Id = id;
            this.Text = text;
        }

        public Note()
        {

        }
    }
}