using System;
using System.Collections.Generic;
using System.Text;

namespace AvailableResourceUpdate
{
    /// <summary>
    /// This exception is thrown when there is invalid configuration file.
    /// </summary>
    class InvalidConfigFileException : Exception
    {
        public InvalidConfigFileException() { }

        public InvalidConfigFileException(string name)
        : base(String.Format("Config file: {0} DOES NOT EXIST!", name)){ }
    }
}
