using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordFinder.Data.Entities.Words;

namespace WordFinder.Data.Context
{
    public class WordFinderContext : DbContext
    {
        public WordFinderContext(DbContextOptions<WordFinderContext> option) : base(option)
        {

        }

        public DbSet<Word> Words { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Word>().HasNoKey();
        }
    }
}
