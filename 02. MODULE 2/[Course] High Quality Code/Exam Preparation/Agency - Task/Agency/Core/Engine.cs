using System;
using Agency.Core.Contracts;
using Bytes2you.Validation;

namespace Agency.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IParser parser;

        private const string TerminationCommand = "Exit";

        public  Engine(IReader reader, IWriter writer, IParser parser)
        {
            Guard.WhenArgument(reader, "reader is null").IsNull().Throw();
            Guard.WhenArgument(writer, "writer is null").IsNull().Throw();
            Guard.WhenArgument(parser, "parser is null").IsNull().Throw();

            this.reader = reader;
            this.writer = writer;
            this.parser = parser;
        }
        

        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString.ToLower() == TerminationCommand.ToLower())
                    {
                        break;
                    }

                    this.writer.WriteLine(this.ProcessCommand(commandAsString));
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }

        private string ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrWhiteSpace(commandAsString))
            {
                throw new ArgumentNullException("Command cannot be null or empty.");
            }

            var command = this.parser.ParseCommand(commandAsString);
            var parameters = this.parser.ParseParameters(commandAsString);

            var executionResult = command.Execute(parameters);
            return executionResult;
        }
    }
}
