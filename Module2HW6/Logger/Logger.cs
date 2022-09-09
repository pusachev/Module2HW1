using System;

namespace Module2HW6.Logger
{
    public sealed class Logger
    {
        private enum Level : byte
        {
            Info = 1,
            Warn = 2,
            Error = 3,
            Debug = 4
        }

        private readonly string _filename = "system.log";
        private StreamWriter _writer;

        private static Logger? _instance;

        private Logger()
        {
            _writer = new StreamWriter(_filename);
        }

        public static Logger GetInstance()
        {
            if (null == _instance)
            {
                _instance = new Logger();
            }

            return _instance;
        }

        public void Info(string Message)
        {
            Log(Level.Info, Message);
        }

        public void Warning(string Message)
        {
            Log(Level.Warn, Message);
        }

        public void Error(string Message)
        {
            Log(Level.Error, Message);
        }

        public void Debug(string Message)
        {
            Log(Level.Debug, Message);
        }

        private void Log(Level Level, string Message, Object? Context = null)
        {
            string logMessage;

            switch (Level)
            {
                case Level.Info:
                {
                    logMessage = "INFO: ";
                    break;
                }
                case Level.Warn:
                {
                    logMessage = "WARN: ";
                    break;
                }
                case Level.Error:
                {
                    logMessage = "ERROR: ";
                    break;
                }
                case Level.Debug:
                {
                    logMessage = "DEBUG: ";
                    break;
                }
                default:
                {
                    logMessage = "DEBUG: ";
                    break;
                 }
            }

            logMessage = logMessage + Message;
            logMessage = logMessage + " | " + DateTime.Now.ToString();


            Console.WriteLine(logMessage);
        }
    }
}
