using System;
using System.ComponentModel.DataAnnotations;

namespace crud_todo_rest_api_netcore.Dtos
{
    public class TodoCreateDto
    {
        [Required]
        [MaxLength(220)]
        public string Title { get; set; }

        [Required]
        [MaxLength(220)]
        public string Description { get; set; }

    }
}
