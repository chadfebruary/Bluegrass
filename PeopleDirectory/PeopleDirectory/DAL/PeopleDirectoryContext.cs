using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using PeopleDirectory.Models;

namespace PeopleDirectory.DAL
{
    public class PeopleDirectoryContext : DbContext
    {
        public PeopleDirectoryContext() : base("PeopleDirectoryContext")
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Admin> Administrators { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}