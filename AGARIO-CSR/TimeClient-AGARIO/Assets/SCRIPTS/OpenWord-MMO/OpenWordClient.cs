using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

namespace OpenWord_MMO
{
    public class OpenWordClient : MonoBehaviour

    {
        static void Main()
        {
            var serverEndPoint = new IPEndPoint(IPAddress.Loopback, 444444);
            var clientEndPoint = new IPEndPoint(IPAddress.Loopback, 444455);

            while (true)
            
            {
                var client = new UdpClient(clientEndPoint);

                Console.WriteLine("The GameServer only accepts Single Words with less than 20 characters!");
            
                var stringInput = Console.ReadLine();
                if (stringInput == null) return;
                var message = Encoding.ASCII.GetBytes(stringInput);
            
                client.Send(message, message.Length, serverEndPoint);
            
                client.Close();
            }
        }
    }
}