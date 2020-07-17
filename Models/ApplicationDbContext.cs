using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_CodeFIrstApproach.Models
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-VSSUM2S\\SQLEXPRESS;user id=angle;password=angle;database=userDb");
        }
        
        public DbSet<User> Users { get; set; }
    }
}
