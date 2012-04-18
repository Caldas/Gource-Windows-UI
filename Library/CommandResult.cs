using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CommandLibrary
{
    //TODO: Create a distinct way to see the result message away from error message
    public class CommandResult
    {
        public String Result { get; private set; }
        public String Error { get; private set; }
        public Boolean HasError { get { return !String.IsNullOrWhiteSpace(Error); } }
        public List<String> Commands { get; private set; }

        public CommandResult(Process processSource, List<String> commands)
        {
            Result = processSource.StandardOutput.ReadToEnd();
            Error = processSource.StandardError.ReadToEnd();
            Commands = commands;
        }
    }
}