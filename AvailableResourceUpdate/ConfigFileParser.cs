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

            string userName = "";
            string passwd = "";
            string pathToResources = "";
            string pathToDbs = "";
            string dbsName = "";

            string[] lines = File.ReadAllLines(fileToParse);
                        
            foreach (string line in lines)
            {
                if (line.Trim().StartsWith("userName"))
                {
                    string[] tokens = line.Split("\"");
                    userName = tokens[1];                    
                }

                if (line.Trim().StartsWith("password"))
                {
                    string[] tokens = line.Split("\"");
                    passwd = tokens[1];                    
                }

                if (line.Trim().StartsWith("pathToResources"))
                {
                    string[] tokens = line.Split("\"");
                    pathToResources = tokens[1];                    
                }

                if (line.Trim().StartsWith("pathToDbs"))
                {
                    string[] tokens = line.Split("\"");
                    pathToDbs = tokens[1];                    
                }

                if (line.Trim().StartsWith("dbsFileName"))
                {
                    string[] tokens = line.Split("\"");
                    dbsName = tokens[1];                    
                }
            }

            return new ConfigInfo(userName,passwd,pathToResources,pathToDbs,dbsName);
        }
    }
}
