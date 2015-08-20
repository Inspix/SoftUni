using LoggerSOLID.Implementations;
using LoggerSOLID.Structure;
using System;

namespace LoggerSOLID
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Logger Test:");
            LoggerTest();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Implementation Test: (output.txt in Debug folder)");
            ImplementationTest();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Extensibility Test:");
            ExtensibilityTest();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Report level Test:");
            ReportTest();
            Console.ReadKey();
            Console.Clear();
        }

        static void LoggerTest()
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender =
                 new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("Error parsing JSON.");
            logger.Info("User {0} successfully registered.", "Pesho");

        }

        static void ImplementationTest()
        {
            var simpleLayout = new SimpleLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);
            var fileAppender = new FileAppender(simpleLayout);
            fileAppender.File = "output.txt";

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info("User {0} successfully registered.", "Pesho");
            logger.Warning("Warning - missing files.");
        }

        static void ExtensibilityTest()
        {
            var xmlLayout = new XmlLayout();
            var consoleAppender = new ConsoleAppender(xmlLayout);

            var logger = new Logger(consoleAppender);
            logger.Fatal("mscorlib.dll does not respond");
            logger.Critical("No connection string found in App.config");

        }

        static void ReportTest()
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportThreshold = ReportLevel.Error;

            var logger = new Logger(consoleAppender);

            logger.Info("Everything seems fine");
            logger.Warning("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");

        }
    }
}
