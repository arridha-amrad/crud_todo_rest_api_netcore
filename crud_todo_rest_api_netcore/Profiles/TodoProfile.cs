using System;
using AutoMapper;
using crud_todo_rest_api_netcore.Dtos;
using crud_todo_rest_api_netcore.Models;

namespace crud_todo_rest_api_netcore.Profiles
{
    public class TodoProfile: Profile
    {
        public TodoProfile()
        {
            // source -> target
            CreateMap<Todo, TodoReadDto>();
            CreateMap<TodoCreateDto, Todo>();
        }
    }
}
