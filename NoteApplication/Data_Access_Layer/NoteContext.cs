using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using NoteApplication.Models;

namespace NoteApplication.Data_Access_Layer
{
    public class NoteContext : DbContext
    {
        public NoteContext() : base("NoteContext")
        {
        #if DEBUG
                    Database.Log = s => { };
        #endif
        }
        public DbSet<Note> Notes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}