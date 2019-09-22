using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EF
{
    public class PhoneBookDbContext : DbContext
    {
        public DbSet<Entities.ContactEntity.Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Initial catalog=ContactDB; integrated security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.ContactEntity.Contact>().HasKey(h => h.ContactId);
            modelBuilder.Entity<Entities.ContactEntity.Contact>().Property(p => p.ContactId).ValueGeneratedOnAdd();
        }
    }
}
