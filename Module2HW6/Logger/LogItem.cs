using System;
namespace Module2HW6.Logger
{
    public class LogItem
    {
        private DateTime _dateTime;
        private string _message;
        private string _type;

        public string Message { get => _message;}

        public string Type { get => _type;}

        public DateTime Date
        {
            get => DateTime.Now.ToLocalTime();
        }

        public LogItem(string type, string message)
        {
            _type       = type;
            _message    = message;
        }

        public override string ToString()
        {
            return String.Format
                (
                    "{0}:[{1}] {2}{3}",
                    Date.ToString(),
                    Type,
                    Message,
                    System.Environment.NewLine
                );
        }
    }
}
