using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities.ToDoTasks;

namespace Todo.Command.CommandsModels.ToDoTaskCommandModels
{
    public class CreateToDoTaskCommandModel
    {
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}

