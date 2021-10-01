using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LibraryApp.Models;

namespace LibraryApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LibraryApp.Models.Department> Departments { get; set; }
        public DbSet<LibraryApp.Models.Book> Books { get; set; }
        public DbSet<LibraryApp.Models.Student> Students { get; set; }
    }
}
