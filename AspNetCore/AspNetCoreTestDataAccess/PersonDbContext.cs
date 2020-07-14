using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTestDataAccess
{
    class PersonDbContext : DbContext // = DataBase...this is our DB
    {
        public DbSet<Person> People { get; set; } // = table
        public DbSet<Address> Address { get; set; } // = table
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Initial Catalog=PersonTestDb;Integrated Security=True;");
        }
    }
}
