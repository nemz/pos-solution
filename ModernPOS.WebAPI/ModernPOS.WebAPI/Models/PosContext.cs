using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ModernPOS.WebAPI.Models
{
    public class PosContext:DbContext
    {
        public PosContext() : base("connectionString") { }

        public DbSet<IdentificationType> identificationtype { get; set; }
        public DbSet<Customer> customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            //primary key
            modelBuilder.Entity<IdentificationType>()
                .HasKey<int>(i => i.Id);

            modelBuilder.Entity<Customer>()
                .HasKey<int>(c => c.Id)
                .HasRequired<IdentificationType>(i => i.IdentificationTypeId)
                .WithMany(c => c.customer);

                
        }
    }
}