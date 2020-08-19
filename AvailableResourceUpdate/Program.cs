using System;
using System.Collections.Generic;
using System.IO;

namespace AvailableResourceUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program ....");

            string configFilePath = "configFile.txt"; //later can be given as argument, now it is not necessary

            try
            {
                ConfigFileParser configParser = new ConfigFileParser(configFilePath);
                ConfigInfo ci = configParser.Parse();

                DbsParser dbsParser = new DbsParser(ci.PathToDbs, ci.DbsFileName);
                Dictionary<string, Page> dbs = dbsParser.Parse();
            }
            catch (InvalidConfigFileException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ending program ...");
            }
            catch (InvalidDbsFileException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ending program ...");
            }
        }
    }
}
