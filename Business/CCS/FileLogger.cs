using System.IO;

namespace Business.CCS
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            using var streamWriter = new StreamWriter("log.log");

            streamWriter.WriteLine("Logged to the file.");
        }
    }
}
