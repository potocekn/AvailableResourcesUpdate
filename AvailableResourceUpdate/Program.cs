using System;
using System.IO;

namespace AvailableResourceUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program ....");

            string configFilePath = "configFile.txt"; //later can be given as argument, now it is not necessary

            if (!File.Exists(configFilePath))
            {
                Console.WriteLine("No config file!");
                Console.WriteLine("Ending the program ...");
                return;
            }


        }
    }
}
