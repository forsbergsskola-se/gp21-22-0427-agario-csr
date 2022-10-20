using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class OpenWordServer
{
    private const int maxLenght = 20;
    private static string message;

    private static IPEndPoint remoteEP = new(IPAddress.Loopback, 44444);
    private static UdpClient _udpClient = new(remoteEP);

    private static void Main()
    {
        while (true)
        {
            IPEndPoint remoteEndopint = default;
            var data = _udpClient.Receive(ref remoteEndopint);
            var massageString = Encoding.ASCII.GetString(data).Trim();

            if (IsValid(massageString)) message += " " + massageString;

            _udpClient.Send(Encoding.ASCII.GetBytes(message), message.Length, remoteEndopint);
        }
    }

    private static bool IsValid(String text) => text.Length > 0 && text.Length <= maxLenght;
}