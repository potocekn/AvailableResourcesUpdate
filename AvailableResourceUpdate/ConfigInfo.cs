using System;
using System.Collections.Generic;
using System.Text;

namespace AvailableResourceUpdate
{
    class ConfigInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PathToResources { get; set; }
        public string PathToDbs { get; set; }
        public string DbsFileName { get; set; }

        public ConfigInfo(string userName, string password, string pathResources, string pathDbs, string dbsName)
        {
            this.UserName = userName;
            this.Password = password;
            this.PathToResources = pathResources;
            this.PathToDbs = pathDbs;
            this.DbsFileName = dbsName;
        }
       
    }
}
