using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Core
{
    public class EntityBase
    {
        public Guid Id { get; set; }
       
        public bool IsDeleted { get; set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
            
            IsDeleted = false;
        }

        public EntityBase(Guid id)
        {
            Id = id;
            
        }

        public void Delete()
        {
            if (IsDeleted)
            {
                throw new Exception("ობიექტი უკვე წაშლილია");
            }
            IsDeleted = true;
        }
    }
}
