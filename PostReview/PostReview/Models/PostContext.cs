using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PostReview.Models
{
    public class PostContext : DbContext
    {
        //public PostContext() : base("DefaultConnection")
        //{

        //}

        public DbSet<User> User { get; set; }

        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}