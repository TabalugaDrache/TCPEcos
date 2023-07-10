
using System.Net.Sockets;

Console.WriteLine("Zug 335 abfahren!");

TcpClient client = new TcpClient();
await client.ConnectAsync("192.168.1.108", 15471);

StreamWriter tcpwriter = new StreamWriter(client.GetStream());
StreamReader tcpreader = new StreamReader(client.GetStream());

await tcpwriter.WriteAsync("queryObjects(10, name, addr, protocol)");

await tcpwriter.FlushAsync();
Console.WriteLine("geschrieben");

string nachricht = "";
bool fertig = false;

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);


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

await tcpwriter.WriteAsync("request(1064, control, force)");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

/////////////////////////////////////

await tcpwriter.WriteAsync("set(1064, func[0, 1]) \nset(1064, func[1, 1]) \nset(1064, func[11,1])" +
    "\nset(1064, func[10,1]) \nset(1064, func[27,0])");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

///////////////////////

Thread.Sleep(5000);

await tcpwriter.WriteAsync("set(1064, speed[127])");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

///////////////////////
///
Thread.Sleep(40000);

await tcpwriter.WriteAsync("set(1064, speed[100])");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

///////////////////////

Thread.Sleep(5000);

await tcpwriter.WriteAsync("set(1064, speed[80])");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

///////////////////////

Thread.Sleep(5000);

await tcpwriter.WriteAsync("set(1064, speed[60])");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

///////////////////////

Thread.Sleep(5000);

await tcpwriter.WriteAsync("set(1064, speed[40])");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

///////////////////////

Thread.Sleep(5000);

await tcpwriter.WriteAsync("set(1064, speed[20])");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

////////////////////////////////////////

Thread.Sleep(5000);
await tcpwriter.WriteAsync("set(1064, speed[0])");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

///////////////////////////////////////////////////
Thread.Sleep(10000);

await tcpwriter.WriteAsync("set(1064, func[1, 0]) \nset(1064, func[0, 0]) \nset(1064, func[11,0])" +
    "\nset(1064, func[10,0]) \nset(1064, func[27,1])");

await tcpwriter.FlushAsync();

nachricht = "";

while (!fertig)
{
    nachricht += "\n" + await tcpreader.ReadLineAsync();

    if (nachricht.Contains("<END"))
    {
        break;
    }
}

Console.WriteLine(nachricht);

