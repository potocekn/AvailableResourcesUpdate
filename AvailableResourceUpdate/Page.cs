using System;
using System.Collections.Generic;
using System.Text;

namespace AvailableResourceUpdate
{
    /// <summary>
    /// This class represents web page. It stores information about page hash, file name for file with its content and url of the page.
    /// Class is used for comparing contents of pages in server and in local database.
    /// </summary>
    class Page
    {
        public string Hash { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public Page(string hash, string fileName, string url)
        {
            this.Hash = hash;
            this.FileName = fileName;
            this.Url = url;
        }
    }
}
