using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        public required string Title { get; set;}
        public DateTimeOffset? DueAt { get; set; }
    }
}