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

        [HttpGet("{id}", Name = "GetTodoById")]
        public ActionResult<Todo> GetTodoById(int id)
        {
            var todo = _repository.GetTodoById(id);
            return Ok(_mapper.Map<TodoReadDto>(todo));
        }

        [HttpPost]
        public ActionResult<Todo> CreateNewTodo(TodoCreateDto todoCreateDto)
        {
            var newTodo = _mapper.Map<Todo>(todoCreateDto);
            _repository.CreateNewTodo(newTodo);
            _repository.SaveChanges();

            var responseBody = _mapper.Map<TodoReadDto>(newTodo);
            return CreatedAtRoute(nameof(GetTodoById), new { Id = newTodo.Id }, responseBody);

        }

        [HttpPut("{id}")]
        public ActionResult UpdateTodo(int id, TodoUpdateDto todoUpdateDto)
        {
            var existingTodo = _repository.GetTodoById(id);
            if(existingTodo == null)
            {
                return NotFound();
            }

            _mapper.Map(todoUpdateDto, existingTodo);

            _repository.UpdateTodo(todoUpdateDto);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
