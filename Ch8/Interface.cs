using System;
using System.IO;

namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger // new and text created
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }


        public void WriteLog(string message)
        {
            writer.WriteLine("{0}, {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("Type temperature : ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog(" current temperature : " + temperature);

            }


        }


        



    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());
            // private ILogger logger <- FileLogger
            // FileLogger.WriteLog
            monitor.start();

        }

    }

}