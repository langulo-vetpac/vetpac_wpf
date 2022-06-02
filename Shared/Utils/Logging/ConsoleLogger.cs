namespace Shared.Utils.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string str)
        {
            Console.WriteLine(str);
        }
    }
}