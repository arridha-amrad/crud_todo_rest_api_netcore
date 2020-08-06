using System;
using System.Collections.Generic;
using crud_todo_rest_api_netcore.Dtos;
using crud_todo_rest_api_netcore.Models;

namespace crud_todo_rest_api_netcore.Repositories
{
    public class DummyTodoRepo : ITodoRepo
    {
        public DummyTodoRepo()
        {
        }

        

        public void CreateNewTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            var todos = new List<Todo>
            {
                new Todo{Id=0, Title="Learning C#", Description="Learning C# from online course", Is_Done=false},
                new Todo{Id=0, Title="Learning C#", Description="Learning C# from online course", Is_Done=false},
                new Todo { Id = 0, Title = "Learning C#", Description = "Learning C# from online course", Is_Done = false }
            };
            return todos;
        }

        public Todo GetTodoById(int id)
        {
            return new Todo { Id = 0, Title = "Learning C#", Description = "Learning C# from online course", Is_Done = false };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateTodo(TodoUpdateDto todo)
        {
            throw new NotImplementedException();
        }
    }
}
