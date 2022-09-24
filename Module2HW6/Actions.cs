using System;
using Module2HW6.Logger;
using Module2HW6.Factory;

namespace Module2HW6
{
    public class Actions
    {
        private Logger.Logger _logger;
        private ResultFactory _resultFactory;

        public Actions()
        {
            _logger = Logger.Logger.GetInstance();
            _resultFactory = new ResultFactory();
        }

        public Result Index()
        {
            _logger.Info("Start method Index");
            return _resultFactory.Create(true, null);
        }

        public Result Create()
        {
            _logger.Warning("Skipped logic in method Create");
            return _resultFactory.Create(true, null);
        }

        public Result Delete()
        {
            return _resultFactory.Create(false, "I broke a logic");
        }
    }
}

