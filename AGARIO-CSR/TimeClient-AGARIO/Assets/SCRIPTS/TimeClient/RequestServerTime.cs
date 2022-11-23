using System;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TimeClient
{
    public class RequestServerTime : MonoBehaviour 

    {
        [SerializeField] TextMeshProUGUI DateAndTimeNowCSR ;
 
        public void SendRequest()
        {
            const int port = 44444;
            var tcpClient = new TcpClient("127.0.0.1", port);

            var serverStream = tcpClient.GetStream();

            var buffer = new byte[100];

            serverStream.Read(buffer, 0, 100);

            var dateTime = Encoding.ASCII.GetString(buffer);

            ChangeText(dateTime);
      
        }

        public void ChangeText(string dateTime) 
   
        {
            DateAndTimeNowCSR.text = "Date and Time now:" + dateTime;
        }
    }
}