using System;

namespace Module2HW6.Logger
{
    public sealed class Logger
    {
        private Logger() { }

        private static Logger? _instance;

        public static Logger GetInstance()
        {
            if (null == _instance)
            {
                _instance = new Logger();
            }

            return _instance;
        }
    }
}
