namespace ReformatCode
{
    using System;
    using System.Text;

    class Program
    {
        static StringBuilder output = new StringBuilder();
        static EventHolder events = new EventHolder();

        static void Main(string[] args)
        {
            Commands.Events = events;
            Messages.Output = output;
            bool running = true;
            while (running)
            {
                running = Commands.ExecuteNextCommand();
            }
            Console.WriteLine(output);
        }
    }
}
