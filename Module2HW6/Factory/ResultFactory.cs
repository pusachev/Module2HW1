using System;
using Module2HW6;

namespace Module2HW6.Factory
{
    public class ResultFactory
    {
        public Result Create(bool status, string? message)
        {
            return new Result(status, message);
        }
    }
}

