using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


public class RequestServerTime : MonoBehaviour 

{
    [SerializeField] Text pressTheButtonText;

    public void SendRequest() 
    
    {
        var serverEndPoint = new IPEndPoint(IPAddress.Loopback, 888);
        var clientEndPoint = new IPEndPoint(IPAddress.Loopback, 889);

        var tcpClient = new TcpClient(clientEndPoint);
        var buffer = new byte[100];
            
        tcpClient.Connect(serverEndPoint);
        tcpClient.GetStream().Read(buffer, 0, buffer.Length);
        
        object textMeshPro = null;
        textMeshPro.text = Encoding.ASCII.GetString(buffer);
        
        tcpClient.Close();
    }
    

    private void UpdateText(string message) 
    
    {
        pressTheButtonText.text = message;
    }
}