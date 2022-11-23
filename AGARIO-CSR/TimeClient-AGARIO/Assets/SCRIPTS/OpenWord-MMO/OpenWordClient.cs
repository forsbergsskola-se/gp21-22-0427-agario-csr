using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace OpenWord_MMO
{
    public class OpenWordClient : MonoBehaviour

    {
        [SerializeField] private InputField _textField;
        [SerializeField] private Text text;
        
        public static IPEndPoint remoteEp = new(IPAddress.Loopback, 44455);
        public static IPEndPoint server = new(IPAddress.Loopback, 44444);
        public static UdpClient udpClient = new(remoteEp);

        public void SendRequest()
        {
            var massage = _textField.text;
            var data = Encoding.ASCII.GetBytes(massage);
            udpClient.Send(data, massage.Length, server);
            var result = udpClient.Receive(ref server);

            text.text = Encoding.ASCII.GetString(result);
            Debug.Log(Encoding.ASCII.GetString(result));
        }
        
        /*static void Main()
        {
            var serverEndPoint = new IPEndPoint(IPAddress.Loopback, 44444);
            var clientEndPoint = new IPEndPoint(IPAddress.Loopback, 44455);

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
        }*/
    }
}