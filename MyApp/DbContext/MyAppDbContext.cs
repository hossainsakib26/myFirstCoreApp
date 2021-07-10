using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyApp.Models.Main_Models;


namespace MyApp.DbContext
{
    public class MyAppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options): base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
    }
}
