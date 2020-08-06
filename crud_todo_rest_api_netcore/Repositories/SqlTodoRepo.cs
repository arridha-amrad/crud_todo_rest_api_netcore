using System;
using System.Collections.Generic;
using System.Linq;
using crud_todo_rest_api_netcore.Models;
using crud_todo_rest_api_netcore.Repositories;

namespace crud_todo_rest_api_netcore.DBContext
{
    public class SqlTodoRepo:ITodoRepo
    {

        private readonly TodoContext _context;

        public SqlTodoRepo(TodoContext context)
        {
            _context = context;
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return _context.Todos.ToList();
        }

        public Todo GetTodoById(int id)
        {
            return _context.Todos.FirstOrDefault(p => p.Id == id);
        }
    }
}
