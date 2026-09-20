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
            // Configure your connection string here.
            // The connection string should NOT be stored here. It is read from your local
            // user secrets store, which lives outside this project folder and is
            // never committed to Git.


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // You may want to add a schema name so all your tables are nicely grouped on the Server

            base.OnModelCreating(modelBuilder);
        }
    }
}
