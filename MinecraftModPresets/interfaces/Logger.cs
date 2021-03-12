using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MinecraftModPresets.interfaces
{
    /// <summary>
    /// A logger interface.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Defines the Log Level.
        /// </summary>
        LogLevel LogLevel { get; set; }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message"> The message. </param>
        /// <param name="level"> The Log level of the message. </param>
        void LogMessage(string message, LogLevel level = LogLevel.Verbose);
    }

    public enum LogLevel
    {
        Verbose = 0,

        Debug = 1,

        Critical = 2
    }

    public class FileLogger : ILogger
    {
        public LogLevel LogLevel { get; set; }
        private string logPath;

        /// <summary>
        /// File path for logs.
        /// </summary>
        /// <param name="path"></param>
        public FileLogger(string path)
        {
            // Set the Log Path
            logPath = path;

            // Ensure folder exists
            Directory.CreateDirectory(Path.GetDirectoryName(logPath));
        }

        /// <summary>
        /// Logs the message to given file
        /// </summary>
        public void LogMessage(string message, LogLevel level = LogLevel.Verbose)
        {
            // If message is important enough, log it
            if (level >= LogLevel)
            {
                using (var fileStream = new StreamWriter(File.OpenWrite(logPath)))
                {
                    // Move to the end of the file
                    fileStream.BaseStream.Seek(0, SeekOrigin.End);

                    // Logs the message
                    fileStream.WriteLine($"Log > {message}");
                }
            }
        }
    }
}
