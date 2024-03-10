using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Contracts
{
    public interface IUnitOfWork
    {
        int SaveChange();
    }
}
