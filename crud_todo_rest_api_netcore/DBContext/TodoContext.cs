using System;
using crud_todo_rest_api_netcore.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_todo_rest_api_netcore.DBContext
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> opt) : base(opt)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
