using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7
{
   public class OutdoorParadise : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // <<SERVER_NAME>>
            options.UseSqlServer(@"Data Source=LAPTOP-RR5830MS\SQLEXPRESS;Initial Catalog=Outdoor Paradise;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        protected override void OnModelCreating(ModelBuilder m)
        {
            m.Entity<Bonus>().HasKey(c => new { c.Emp_ID, c.Bonus_date, c.Bonus_amount });
            m.Entity<Excursion_planned>().HasKey(c => new { c.Excursion, c.Travel_planned});

        }



        public DbSet<Country> Country { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Order_Details> Order_Details { get; set; }
        public DbSet<Order_Header> Order_Header { get; set; }
        public DbSet<Travel_planned> Travel_planned { get; set; }
        public DbSet<Travel_product> Travel_product { get; set; }
        public DbSet<Excursion> Excursion { get; set; }
        public DbSet<Excursion_planned> Excursion_planned { get; set; }

    }
}
