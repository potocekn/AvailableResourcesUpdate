using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AvailableResourceUpdate
{
    class ConfigFileParser
    {
        string fileToParse;

        public ConfigFileParser(string fileName)
        {
            this.fileToParse = fileName;
        }

        public ConfigInfo Parse()
        {
            if (!File.Exists(fileToParse))
            {
                throw new InvalidConfigFileException(fileToParse);
            }

            ConfigInfo result;


            return null;
        }
    }
}
