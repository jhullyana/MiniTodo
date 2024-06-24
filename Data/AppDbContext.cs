using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MiniTodo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}