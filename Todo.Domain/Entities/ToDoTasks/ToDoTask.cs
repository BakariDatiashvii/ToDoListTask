using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Core;

namespace Todo.Domain.Entities.ToDoTasks
{
    public class ToDoTask :EntityBase
    {
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}
