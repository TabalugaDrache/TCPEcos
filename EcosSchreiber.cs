using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPEcos
{
    internal class EcosSchreiber
    {
        internal async Task Schreiben(TcpClient client)
        {
            bool weiterSchreiben = true;
            StreamWriter schreiber = new StreamWriter(client.GetStream());

            while (weiterSchreiben)
            {
                Console.WriteLine("Befehl eingeben:");
                string befehl = Console.ReadLine();

                Console.WriteLine("_________________________________________________________");

                if (befehl == "esc" || befehl == "ende")
                {
                    weiterSchreiben = false;
                    schreiber.Close();
                }

                else
                {
                    await schreiber.WriteLineAsync(befehl);
                    await schreiber.FlushAsync();
                }
            }
        }
    }
}
