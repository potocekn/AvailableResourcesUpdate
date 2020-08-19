using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AvailableResourceUpdate
{
    class DbsParser
    {
        string pathToFile;
        string fileToParse;

        public DbsParser(string pathToFile, string fileName)
        {
            this.pathToFile = pathToFile;
            this.fileToParse = fileName;
        }

        public Dictionary<string, Page> Parse()
        {
            string dbsFile = pathToFile + fileToParse;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(dbsFile);

                string line;
                Dictionary<string, Page> result = new Dictionary<string, Page>();

                while ((line = file.ReadLine()) != null)
                {
                    string[] tokens = line.Split(";");
                    string url = tokens[0].Trim();
                    string hash = tokens[1].Trim();
                    string fileName = tokens[2].Trim();
                    result.Add(url, new Page(hash, fileName, url));
                }

                file.Close();
                return result;
            }
            catch (IOException e)
            {
                throw new InvalidDbsFileException(pathToFile, fileToParse);
            }          
        }
    }
}
