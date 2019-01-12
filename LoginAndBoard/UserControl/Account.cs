using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LoginAndBoard.UserControl
{
    public class Account : IdentityUser
    {
        public long Id { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<Post> Posts { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset UpdatedAt { get; set; }

        public Account()
        {

        }
    }
}
