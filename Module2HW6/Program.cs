// See https://aka.ms/new-console-template for more information

using Module2HW6.Logger;

Logger logger = Logger.GetInstance();

logger.Info("Test");
logger.Warning("Test 2");

Console.ReadLine();