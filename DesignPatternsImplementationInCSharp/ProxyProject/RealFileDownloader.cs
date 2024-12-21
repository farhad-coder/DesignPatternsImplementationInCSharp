using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyProject
{
    public class RealFileDownloader : IFileDownloader
    {
        public void DownloadFile(string url)
        {
            Console.WriteLine($"Downloading file from {url}");

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Download complete.");
        }
    }
}
