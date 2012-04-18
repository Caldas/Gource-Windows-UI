// -----------------------------------------------------------------------
// <copyright file="Command.cs" company="VTEX OnLine Applications">
//     Copyright (c) VTEX OnLine Applications. All rights reserved.
// </copyright>
// <author>Fábio Caldas</author>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CommandLibrary
{
    public static class Command
    {
        public static CommandResult Execute(List<String> commands)
        {
            try
            {
                List<String> executedCommands = new List<String>();

                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = "cmd.exe";
                processStartInfo.RedirectStandardInput = true;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.CreateNoWindow = true;

                Process gitProcess = new Process();
                gitProcess.StartInfo = processStartInfo;
                gitProcess.Start();

                using (StreamWriter streamWriter = gitProcess.StandardInput)
                {
                    if (streamWriter.BaseStream.CanWrite)
                    {
                        foreach (String processCommand in commands)
                        {
                            streamWriter.WriteLine(processCommand);
                            executedCommands.Add(processCommand);
                        }
                    }
                }

                return new CommandResult(gitProcess, executedCommands);
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }
    }
}