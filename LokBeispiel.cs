using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPEcos
{
    internal static class LokBeispiel
    {
        internal static async void StartAsync(int lokNummer, TcpClient client)
        {
            Console.WriteLine("Zug 335 abfahren!");

            StreamWriter tcpwriter = new StreamWriter(client.GetStream());

            await tcpwriter.WriteAsync("queryObjects(10, name, addr, protocol)");
            await tcpwriter.FlushAsync();

            await tcpwriter.WriteAsync($"request({lokNummer}, control, force)");
            await tcpwriter.FlushAsync();

            await tcpwriter.WriteAsync($"set({lokNummer}, func[0, 1]) \nset({lokNummer}, func[1, 1]) \nset({lokNummer}, func[11,1])" +
                $"\nset({lokNummer}, func[10,1]) \nset({lokNummer}, func[27,0])");
            await tcpwriter.FlushAsync();

            Thread.Sleep(5000);

            await tcpwriter.WriteAsync($"set({lokNummer}, speed[127])");
            await tcpwriter.FlushAsync();

            Thread.Sleep(40000);

            await tcpwriter.WriteAsync($"set({lokNummer}, speed[100])");
            await tcpwriter.FlushAsync();


            Thread.Sleep(5000);

            await tcpwriter.WriteAsync($"set({lokNummer}, speed[80])");
            await tcpwriter.FlushAsync();


            Thread.Sleep(5000);

            await tcpwriter.WriteAsync($"set({lokNummer}, speed[60])");
            await tcpwriter.FlushAsync();

            Thread.Sleep(5000);

            await tcpwriter.WriteAsync($"set({lokNummer}, speed[40])");
            await tcpwriter.FlushAsync();

            Thread.Sleep(5000);

            await tcpwriter.WriteAsync($"set({lokNummer}, speed[20])");
            await tcpwriter.FlushAsync();

            Thread.Sleep(5000);

            await tcpwriter.WriteAsync($"set({lokNummer}, speed[0])");
            await tcpwriter.FlushAsync();

            Thread.Sleep(10000);

            await tcpwriter.WriteAsync($"set({lokNummer}, func[1, 0]) \nset({lokNummer}, func[0, 0]) \nset({lokNummer}, func[11,0])" +
                $"\nset({lokNummer}, func[10,0]) \nset({lokNummer}, func[27,1])");
            await tcpwriter.FlushAsync();

            tcpwriter.Close();

            client.Close();
        }
    }
}
