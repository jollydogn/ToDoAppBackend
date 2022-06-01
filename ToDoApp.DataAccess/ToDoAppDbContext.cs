using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Entities;

namespace ToDoApp.DataAccess
{
    class ToDoAppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=DESKTOP-EN2H259;initial catalog=ToDoAppDb;integrated security=True;");
        }
        public DbSet<ToDo> toDos { get; set; }

    }
}
