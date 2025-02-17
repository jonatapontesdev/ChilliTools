using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JPRagTools.Model;
using JPRagTools.Utils;
using Newtonsoft.Json;

namespace JPRagTools.Forms
{
    public partial class ClientUpdaterForm : Form
    {
        private System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();

        public ClientUpdaterForm()
        {
            var requestAccepts = httpClient.DefaultRequestHeaders.Accept;
            requestAccepts.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.UserAgent.TryParseAdd("request"); //Set the User Agent to "request"
            InitializeComponent();
            StartUpdate();
        }

        private async void StartUpdate()
        {
            List<ClientDTO> clients = new List<ClientDTO>();


            /**
             * Try to load remote supported_server.json file and append all data in clients list.
             */
            try
            {
                clients.AddRange(LocalServerManager.GetLocalClients()); //Load Local Servers First
                //If fetch successfully update and load local file.
                httpClient.Timeout = TimeSpan.FromSeconds(5);
                string remoteServersRaw = await httpClient.GetStringAsync(AppConfig._JPClientsURL);
                clients.AddRange(JsonConvert.DeserializeObject<List<ClientDTO>>(remoteServersRaw));

            }
            catch (Exception ex)
            {
                //If catch some exception while Fetch, load resource file.
                MessageBox.Show("Não é possível carregar o arquivo supported_servers. Carregando recurso em vez disso....");
                clients.AddRange(JsonConvert.DeserializeObject<List<ClientDTO>>(LoadResourceServerFile()));
            }
            finally
            {
                LoadServers(clients);
                new Container().Show();
                //Hide();
            }
        }

        private string LoadResourceServerFile()
        {
            return Resources.JPRagTools.ETCResource.supported_servers;
        }

        private void LoadServers(List<ClientDTO> clients)
        {
            foreach (ClientDTO clientDTO in clients)
            {
                try
                {
                    ClientListSingleton.AddClient(new Client(clientDTO));
                    pbSupportedServer.Increment(1);
                }
                catch { }

            }
        }
    }
}
