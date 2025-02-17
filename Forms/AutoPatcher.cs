using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using JPRagTools.Utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using Aspose.Zip.Rar;
using System.Net;
using System.Runtime.InteropServices;

namespace JPRagTools.Forms
{
    public partial class AutoPatcher : Form
    {
        private HttpClient client = new HttpClient();
        public AutoPatcher()
        {
            InitializeComponent();
            StartAutopatcher();
        }

        private async void StartAutopatcher()
        {
            //Get Latest Version
            //List[0] = Tag
            //List[1] = Url
            try
            {
                String oldFileName = "4RTools_old.exe";
                String sourceFileName = "4RTools.exe";
                File.Delete(oldFileName); //Delete old 4RTools
                client.Timeout = TimeSpan.FromSeconds(5);
                client.DefaultRequestHeaders.Add("User-Agent", "request");
                string latestVersion = await client.GetStringAsync(AppConfig._JPLatestVersionURL);
                JObject obj = JsonConvert.DeserializeObject<JObject>(latestVersion);

                string tag = obj["name"].ToString(); //Tag Name

                if (tag != AppConfig.Version)
                {
                    string downloadUrl = obj["assets"][0]["browser_download_url"].ToString(); //Latest download url
                    string fileName = obj["assets"][0]["name"].ToString(); //Latest file name
                    await Download(downloadUrl, fileName); //Download the .rar file
                    RarArchive arch = new RarArchive(fileName);
                    File.Move(sourceFileName, oldFileName);
                    arch.ExtractToDirectory(".");
                    arch.Dispose();
                    File.Delete(fileName); //Delete .rar file downloaded
                    Environment.Exit(0);
                }

            }
            finally
            {
                new ClientUpdaterForm().Show();
                Hide();
            }
        }

        private async Task<bool> Download(string url, string filename)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(_JPTools_DownloadProgressChanged);
            await client.DownloadFileTaskAsync(url, @filename);
            return true;
        }

        void _JPTools_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                pbPatcher.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
    }
}
