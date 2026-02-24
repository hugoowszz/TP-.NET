namespace _5;

class Program
{
    public class DownloadEventArgs : EventArgs
    {
        public string FileName { get; set; }
        public DateTime Finished { get; set; }

        public DownloadEventArgs(string fileName, DateTime finished)
        {
            FileName = fileName;
            Finished = DateTime.Now;
        }
    }

    public class DownloadManager
    {
        public event EventHandler<DownloadEventArgs> Download;

        public void iniciarDownload(string fileName)
        {
            Console.WriteLine("Iniciando download: " + fileName);

            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Baixando... "+ i*10+"%");
            }
            
            OnDownloadCompleted(new DownloadEventArgs(fileName, DateTime.Now));
        }
        protected virtual void OnDownloadCompleted(DownloadEventArgs e)
        {
            Download?.Invoke(this, e);
        }
    }
    
    static void Main(string[] args)
    {
        DownloadManager dm = new DownloadManager();

        dm.Download += (sender, e) =>
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Arquivo: " + e.FileName + " baixado em: " + e.Finished);
            Console.ResetColor();
        };
        
        dm.iniciarDownload("Rock lee vs Gaara - Linkin park.mp4");
    }
}