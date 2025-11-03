using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDoApp.Models;

namespace ToDoApp.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            // Represents the To-Do table in the database
            public DbSet<ToDoItem> ToDoItems { get; set; }
        }
    }

