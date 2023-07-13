using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPEcos
{
    internal class EcosLeser
    {
        private bool Lesen = true;
        private TcpClient Client = null;

        internal async void StartAsync(TcpClient client)
        {
            this.Client = client;
            await this.LesenAsync();
        }

        internal void Beenden()
        {
            this.Lesen = false;
        }


        private async Task LesenAsync()
        {
            StreamReader leser = new StreamReader(Client.GetStream());

            while (Lesen)
            {
                Console.WriteLine(await leser.ReadLineAsync());
            }

            leser.Close();
        }
    }
}
