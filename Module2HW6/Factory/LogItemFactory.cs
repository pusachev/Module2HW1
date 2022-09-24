using System;
using Module2HW6.Logger;

namespace Module2HW6.Factory
{
    public class LogItemFactory
    {
        public LogItem Create(string type, string message)
        {
            return new LogItem(type, message);
        }
    }
}

