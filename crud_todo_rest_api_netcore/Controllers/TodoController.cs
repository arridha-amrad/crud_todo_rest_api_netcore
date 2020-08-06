using System;
using System.Collections.Generic;
using crud_todo_rest_api_netcore.Models;
using crud_todo_rest_api_netcore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace crud_todo_rest_api_netcore.Controllers
{
    [ApiController]
    [Route("/api/todo")]
    public class TodoController : ControllerBase
    {
        public readonly ITodoRepo _repository;

        public TodoController(ITodoRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAllTodos()
        {
            var todos = _repository.GetAllTodos();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodoById(int id)
        {
            var todo = _repository.GetTodoById(id);
            return Ok(todo);
        }
    }
}
