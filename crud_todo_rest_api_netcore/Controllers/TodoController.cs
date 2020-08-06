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
        public readonly DummyTodoRepo repository = new DummyTodoRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAllTodos()
        {
            var todos = repository.GetAllTodos();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodoById(int id)
        {
            var todo = repository.GetTodoById(id);
            return Ok(todo);
        }
    }
}
