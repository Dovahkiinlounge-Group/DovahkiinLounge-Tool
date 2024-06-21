using System.Net;
using System.IO.Compression;

namespace DovahkiinLounge.Functions
{
    public class DownloadManager
    {
        public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
        public event EventHandler<DownloadCompletedEventArgs> DownloadCompleted;

        public void DownloadAndExtractZip(string url, string downloadFolderPath)
        {
            string zipFilePath = Path.Combine(downloadFolderPath, "Release.zip");

            DownloadFile(url, zipFilePath);
        }

        public void DownloadAndExtractZipv2(string url, string downloadFolderPath)
        {
            // Generiere einen zufälligen Dateinamen für die heruntergeladene ZIP-Datei
            string zipFileName = Guid.NewGuid().ToString() + ".zip";
            string zipFilePath = Path.Combine(downloadFolderPath, zipFileName);

            DownloadFile(url, zipFilePath);
        }

        private void DownloadFile(string url, string filePath)
        {
#pragma warning disable SYSLIB0014 // Typ oder Element ist veraltet
            WebClient client = new();
#pragma warning restore SYSLIB0014 // Typ oder Element ist veraltet

            client.DownloadProgressChanged += (s, e) =>
            {
                OnProgressChanged(new ProgressChangedEventArgs(e.ProgressPercentage));
            };

            client.DownloadFileCompleted += (s, e) =>
            {
                if (e.Error == null)
                {
                    OnDownloadCompleted(new DownloadCompletedEventArgs(filePath));
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
                    ExtractAndDelete(filePath, Path.GetDirectoryName(filePath)); // Extract and delete the ZIP file
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
                }
                else
                {
                    OnDownloadCompleted(new DownloadCompletedEventArgs(filePath, e.Error));
                    ErrorLogv2.LogError(e.Error); // Log the error using your existing logger
                }
            };

            client.DownloadFileAsync(new Uri(url), filePath);
        }

        private void ExtractAndDelete(string zipFilePath, string extractToFolderPath)
        {
            try
            {
                // Check if the ZIP file is valid before extraction
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                {
                    // Proceed with extraction
                    ZipFile.ExtractToDirectory(zipFilePath, extractToFolderPath);

                    // Dispose of the ZipArchive to release any resources
                    archive.Dispose();

                    // Introduce a short delay to ensure the extraction is complete
                    System.Threading.Thread.Sleep(1000);

                    File.Delete(zipFilePath);
                }
            }
            catch (Exception ex)
            {
                OnDownloadCompleted(new DownloadCompletedEventArgs(zipFilePath, ex));
                ErrorLogv2.LogError(ex); // Log the error using your existing logger
            }
        }



        protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
        {
            ProgressChanged?.Invoke(this, e);
        }

        protected virtual void OnDownloadCompleted(DownloadCompletedEventArgs e)
        {
            DownloadCompleted?.Invoke(this, e);
        }
    }

    public class ProgressChangedEventArgs : EventArgs
    {
        public int ProgressPercentage { get; }

        public ProgressChangedEventArgs(int progressPercentage)
        {
            ProgressPercentage = progressPercentage;
        }
    }

    public class DownloadCompletedEventArgs : EventArgs
    {
        public string FilePath { get; }
        public Exception Error { get; }

        public DownloadCompletedEventArgs(string filePath)
        {
            FilePath = filePath;
            Error = null;
        }

        public DownloadCompletedEventArgs(string filePath, Exception error)
        {
            FilePath = filePath;
            Error = error;
        }
    }
}
