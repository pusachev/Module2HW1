using System;
namespace Module2HW6
{
    public class Result
    {
        private bool _status;
        private string? _message;

        public bool Status { get => _status; }
        public string? Message { get => _message; }

        public Result(bool status, string? message)
        {
            _status = status;
            _message = message;
        }
    }
}
