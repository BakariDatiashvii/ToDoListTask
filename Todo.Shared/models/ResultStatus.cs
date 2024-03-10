using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Shared.models
{
    public enum ResultStatus
    {
        Success = 1,
        Error = 0,
        Unauthorized = 3,
        AccessDenied = 4,
        NotFound = 5,
        UnActivated = 6
    }
}
