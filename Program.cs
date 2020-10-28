using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace readFile
{
    class Program
    {
        static void Main(string[] args){
            // have to use this method of getting a new webclient instead, in older versions
            var wc = new System.Net.WebClient();
            string remoteUri = "http://www.contoso.com/library/homepage/images/";
            string fileName = "ms-banner.gif", myStringWebResource = null;
            // Create a new WebClient instance.
            //WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri + fileName;
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the current filesystem folder.
            wc.DownloadFile(myStringWebResource,fileName);		
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
            Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + "Application.StartupPath");
          


        }
    } // end class
} // end namespace




