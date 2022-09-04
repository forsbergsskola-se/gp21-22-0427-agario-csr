using System.Net.Sockets;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class RequestServerTime : MonoBehaviour

{
    public Text Text_DateAndTimeNowCSR;

    public void SendRequest() 
    
    {
        TcpClient tcpClient = new TcpClient("127.0.0.1", 44444);

        var serverStream = tcpClient.GetStream();
        
        byte[] buffer = new byte[100];
        
        serverStream.Read(buffer, 0, 100);
        
        string dateTime = Encoding.ASCII.GetString(buffer);

        ChangeText(dateTime);
    }
    

    public void ChangeText(string dateTime) 
    
    {
        Text_DateAndTimeNowCSR.text = dateTime;
    }
}
