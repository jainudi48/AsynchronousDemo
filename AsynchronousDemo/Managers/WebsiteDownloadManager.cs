using AsynchronousDemo.Data;
using System.Diagnostics;
using System.Net;

namespace AsynchronousDemo.Managers
{
    class WebsiteDownloadManager
    {
        private WebDataModel webDataModel;

        public WebsiteDownloadManager()
        {
            webDataModel = new WebDataModel();
        }
        public int DownloadWebsite(string jobURI)
        {
            Stopwatch stopwatch;
            WebClient webClientLocal = new WebClient();
            stopwatch = Stopwatch.StartNew();
            webDataModel.URI = jobURI;
            webDataModel.WebData = webClientLocal.DownloadString(jobURI);
            stopwatch.Stop();
            return stopwatch.Elapsed.Milliseconds;
        }
    }
}
