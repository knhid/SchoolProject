using System;
using LoginAndBoard.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginAndBoard.DataContext
{
    public class NoteDBContext : DbContext
    {
        public NoteDBContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(@"Server=localhost;Database=myNoteDB;Uid=root;Pwd=rootroot;");
            //optionsBuilder.UseMySql(@"Driver={MySQL ODBC 5.1 Driver};Server=localhost;Database=myNoteDB;
                                    //User=root;Password=rootroot;Option=3;");
        }
    }
}
