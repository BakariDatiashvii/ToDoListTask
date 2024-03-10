using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities.ToDoTasks;

namespace Todo.Query.ViewModels.ToDoTaskVM
{
    public class ToDoTaskViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Status status { get; set; }
    }
}
