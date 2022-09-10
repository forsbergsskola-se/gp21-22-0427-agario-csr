using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace OpenWord_MMO
{

    public class serverUDP
    {
        public void ConsMesage()
        {
            byte[] data = new byte[1024];
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 44444);
            UdpClient newsock = new UdpClient(ip);

            Console.WriteLine("Waiting for a client...");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 44444);

            data = newsock.Receive(ref sender);

            Console.WriteLine("Message received from {0}:", sender.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));

            string welcome = "Welcome to server";
            data = Encoding.ASCII.GetBytes(welcome);
            newsock.Send(data, data.Length, sender);

            while (true)
            {
                data = newsock.Receive(ref sender);

                Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
                newsock.Send(data, data.Length, sender);
            }
        }
    }
}
