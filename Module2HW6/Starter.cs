using System;
using Module2HW6;

namespace Module2HW6
{
    public class Starter
    {
        const int ITERATION_COUNT = 100;
        const int MIN = 0;
        const int MAX = 3;

        private Actions _actions;

        public Starter()
        {
            _actions = new Actions();
        }

        public void Run()
        {
            for (int i = 0; i <= ITERATION_COUNT; i++)
            {
                Result result;

                switch (GetRandomNum())
                {
                    case 0:
                        result = _actions.Index();
                        break;
                    case 1:
                        result = _actions.Create();
                        break;
                    case 2:
                        result = _actions.Delete();
                        break;
                    default:
                        continue;
                }

                if (!result.Status)
                {
                    Logger.Logger
                          .GetInstance()
                          .Error("Action failed by a reason: " + result.Message);
                }
            }

            Logger.Logger.GetInstance().Flush();
        }

        private int GetRandomNum()
        {
            Random rand = new Random();

            return rand.Next(MIN, MAX);
        }
    }
}

