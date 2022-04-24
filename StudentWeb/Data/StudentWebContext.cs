#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentWeb.Models;

namespace StudentWeb.Data
{
    public class StudentWebContext : DbContext
    {
        public StudentWebContext (DbContextOptions<StudentWebContext> options)
            : base(options)
        {
        }

        public DbSet<StudentWeb.Models.Student> Student { get; set; }
    }
}
