using ModernPOS.Data.Access.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ModernPOS.Data.Access.Context
{
    public class PosContext:DbContext
    {
        public PosContext() : base("connectionString") { }

        public DbSet<Customer> customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            modelBuilder.Entity<Customer>()
                .HasKey<int>(c => c.Id);

                
        }
    }
}