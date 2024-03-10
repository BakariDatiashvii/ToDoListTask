using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities.ToDoTasks;

namespace Todo.Command.CommandsModels.ToDoTaskCommandModels
{
    public class UpdateToDoTaskCommandModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}
