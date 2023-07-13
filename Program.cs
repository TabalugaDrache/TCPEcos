
using System.Net.Sockets;
using TCPEcos;

try
{
    Console.WriteLine("IP Adresse der ECOS eingeben:");
    string ip = Console.ReadLine();

    int port = 15471;

    TcpClient client = new TcpClient();
    client.Connect(ip, port);

    Console.WriteLine("Willkommen in der Fernsteuerung!");
    Console.WriteLine("------------------------------------------------------------------------------");

    EcosLeser leser = new EcosLeser();
    Task.Run(() => leser.StartAsync(client));

    EcosSchreiber schreiber = new EcosSchreiber();

    await schreiber.Schreiben(client);
}

catch(Exception e)
{
    Console.WriteLine("Es ist ein Fehler aufgetreten:");
    Console.WriteLine(e.Message);
    Console.WriteLine("Das Programm wird beendet.");
}



////////////////////////////
/*
await tcpwriter.WriteAsync("help(11, get, switch)");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    Console.WriteLine(await tcpreader.ReadLineAsync());

    if (nachricht.Contains("<END"))
    {
        break;
    }
}*/
////////////////////////////



