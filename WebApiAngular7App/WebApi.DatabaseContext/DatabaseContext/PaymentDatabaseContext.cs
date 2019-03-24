using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.DatabaseContext.DatabaseContext
{
    public class PaymentDatabaseContext:DbContext
    {
        //public PaymentDatabaseContext()
        //{

        //}
        public PaymentDatabaseContext(DbContextOptions<PaymentDatabaseContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-L0SIFSL\SQLEXPRESS;Database=PersonDB;Trusted_Connection=True;");
        //}

        public DbSet<PaymentDetail> PaymentDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.CardOwnerName)
                .IsRequired();

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.CardNumber)
                .IsRequired();

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.ExpirationDate)
                .IsRequired();

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.CVV)
                .IsRequired();
        }
    }
}
