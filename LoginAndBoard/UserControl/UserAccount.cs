using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LoginAndBoard.UserControl
{
    public class UserAccount : DbContext
    {
        public DbSet<Login> LoginUser { get; set; }
        public DbSet<Join> JoinUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=accounts.db");
        }
    }

    public class Login
    {
        [Key]
        public int UserNo { get; set; }

        [Required]
        public string UserID { get; set; }

        [Required]
        public string UserPW { get; set; }

        //public ICollection<Join> Users { get; set; }
    }

    public class Join
    {
        [Key]
        public string UserID { get; set; }

        [Required]
        public string UserPW { get; set; }

        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string UserName { get; set; }
        //public Blog Blog { get; set; }
    }
}
