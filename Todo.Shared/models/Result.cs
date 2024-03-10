using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Shared.models
{
    public class Result
    {
        public string Message { get; set; }

        public object Response { get; set; }

        public ResultStatus Statuss { get; set; } = ResultStatus.Success;

        public static Result Success()
        {
            return new Result(ResultStatus.Success);
        }

        public static Result Success(string message)
        {
            return new Result(message, ResultStatus.Success);
        }

        public static Result Success(object responce)
        {
            return new Result(ResultStatus.Success, responce);
        }

        public static Result Error(string message)
        {
            return new Result(message, ResultStatus.Error);
        }

        public static Result AccessDenied(string message)
        {
            return new Result(message, ResultStatus.AccessDenied);
        }

        public static Result Unauthorized(string message)
        {
            return new Result(message, ResultStatus.Unauthorized);
        }

        public Result()
        {
        }

        public Result(ResultStatus status)
        {
            Statuss = status;
        }

        public Result(ResultStatus status, object responce)
        {
            Statuss = status;
            Response = responce;
        }

        public Result(string message, ResultStatus status)
        {
            Message = message;
            Statuss = status;
        }

    }
}
