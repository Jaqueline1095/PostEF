using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PostEF.Models;
namespace PostEF.DB
{
    public class PostContext : DbContext
    {
       public DbSet<Post> Post { get; set; }
       public DbSet<Category> Category { get; set; }
       public DbSet<Comment> Coment { get; set; }
       
    }
}