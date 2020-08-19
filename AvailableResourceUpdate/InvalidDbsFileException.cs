using System;
using System.Collections.Generic;
using System.Text;

namespace AvailableResourceUpdate
{
    class InvalidDbsFileException : Exception
    {
        public InvalidDbsFileException() { }

        public InvalidDbsFileException(string path, string name)
        : base(String.Format("Dbs file: {0}{1} DOES NOT EXIST!", path, name)) { }
    }
}
