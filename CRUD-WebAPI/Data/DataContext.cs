using System;
using System.Collections.Generic;
using CRUD_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Developer> Developers { get; set; }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     // builder.Entity<Developer>()
        //     //     .HasData(new List<Developer>(){
        //     //         new Developer(1, "Fernando Gonsales", 'M', 20, "Jogar", new DateTime(02, 04, 2001)),
        //     //     });
        // }
    }
}