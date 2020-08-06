using System;
using System.Collections.Generic;
using crud_todo_rest_api_netcore.Dtos;
using crud_todo_rest_api_netcore.Models;

namespace crud_todo_rest_api_netcore.Repositories
{
    public interface ITodoRepo
    {
        IEnumerable<Todo> GetAllTodos();
        Todo GetTodoById(int id);
        void CreateNewTodo(Todo todo);
        void UpdateTodo(TodoUpdateDto todo);
        void DeleteTodo(Todo todo);
        bool SaveChanges();
    }
}
