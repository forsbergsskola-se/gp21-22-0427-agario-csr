using System;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class RequestServerTime : MonoBehaviour 

{
    [SerializeField] Text Text_DateandTimenow;

    public void SendRequest() 
    
    {
        TcpClient tcpClient = new TcpClient("127.0.0.1", 44444);

        var stream = tcpClient.GetStream();
        
        byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
        stream.Read(bytes, 0, bytes.Length);
        
        string message = Encoding.ASCII.GetString(bytes);

        UpdateText(message);
    }

    private void UpdateText(string message) 
    
    {
        Text_DateandTimenow.text = message;
    }
}


// using System;
// using System.Net;
// using System.Net.Sockets;
// using System.Text;
// using TMPro;
// using UnityEngine;
// using UnityEngine.UI;
//
//
// namespace TimeClient
// {
//     public class RequestServerTime : MonoBehaviour
//     {
//         /*[SerializeField] private TextMeshProUGUI textMeshPro;
//         
//         public void SendRequest()
//         {
//             // var serverEndPoint = new IPEndPoint(IPAddress.Loopback, 44444);
//             // var clientEndPoint = new IPEndPoint(IPAddress.Loopback, 44445);
//             TcpClient tcpClient = new TcpClient("127.0.0.1", 44444);
//             byte[] buffer = new byte[tcpClient.100];
//
//             IPEndPoint serverEndPoint = null;
//             tcpClient.Connect(serverEndPoint);
//             tcpClient.GetStream().Read(buffer, 0, buffer.Length);
//             textMeshPro.text = Encoding.ASCII.GetString(buffer);
//             tcpClient.Close();*/
//         
//     }
// }