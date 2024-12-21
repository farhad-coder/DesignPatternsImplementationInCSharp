using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyProject
{
    public interface IFileDownloader
    {
        void DownloadFile(string url);
    }
}
