using System;
using System.ComponentModel.DataAnnotations;

namespace crud_todo_rest_api_netcore.Dtos
{
    public class TodoReadDto
    {

        [Required]
        [MaxLength(220)]
        public string Title { get; set; }

        [Required]
        [MaxLength(220)]
        public string Description { get; set; }

        [Required]
        public bool Is_Done { get; set; }

    }
}
