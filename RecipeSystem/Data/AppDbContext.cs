using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem.Data
{
    internal class AppDbContext : DbContext
    {
        // Add a DbSet<T> property here for each class you add to Models/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your connection here.
            // Do NOT write your connection string in this file: it would be committed to Git.
            // A secure approach to use is covered in the lecture and lab on Entity Framework.


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // You may want to add a schema name so all your tables are nicely grouped on the Server

            base.OnModelCreating(modelBuilder);
        }
    }
}
