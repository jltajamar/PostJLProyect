using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PostJLProyect.Models
{
    public class UserContext : DbContext
    {

        public UserContext() : base("name=stringuser") { }


        public DbSet<User> Users { get; set; }


    }
}