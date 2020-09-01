using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoItemApp3Camadas.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoItemApp3Camadas.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
