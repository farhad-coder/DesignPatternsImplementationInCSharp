
using ProxyProject;

IFileDownloader fileDownloader = new FileDownloaderProxy();

fileDownloader.DownloadFile("http://example.com/file1");

fileDownloader.DownloadFile("http://example.com/file1");

fileDownloader.DownloadFile("http://example.com/file2");