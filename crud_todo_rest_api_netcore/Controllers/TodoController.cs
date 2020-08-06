using System;
using System.Collections.Generic;
using AutoMapper;
using crud_todo_rest_api_netcore.Dtos;
using crud_todo_rest_api_netcore.Models;
using crud_todo_rest_api_netcore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace crud_todo_rest_api_netcore.Controllers
{
    [ApiController]
    [Route("/api/todo")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepo _repository;
        private readonly IMapper _mapper;


        public TodoController(ITodoRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAllTodos()
        {
            var todos = _repository.GetAllTodos();

            return Ok(_mapper.Map<IEnumerable<TodoReadDto>>(todos));
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodoById(int id)
        {
            var todo = _repository.GetTodoById(id);
            return Ok(_mapper.Map<TodoReadDto>(todo));
        }
    }
}
