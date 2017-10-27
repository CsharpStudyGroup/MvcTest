using MvcTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTest
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}