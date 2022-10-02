using System;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class RequestServerTime : MonoBehaviour 

{
  [SerializeField] Text text_DateAndTimeNowCSR ;
 
   public void Send()
   {
        int port = 444444;
        TcpClient tcpClient = new TcpClient("127.0.0.1", port);

        var serverStream = tcpClient.GetStream();

        byte[] buffer = new byte[100];

        serverStream.Read(buffer, 0, 100);

        string dateTime = Encoding.ASCII.GetString(buffer);

       ChangeText(dateTime);
      
   }

   public void ChangeText(string dateTime) //string dateTime
   
    {
     text_DateAndTimeNowCSR.text = "Date and Time now:" + dateTime;
                                              // dateTime = numBer;
                                              // numBer += 10;
                                              // Console.WriteLine(numBer);
                                              /*_number += 10;
                                                textField.text = "Date and Time now:" + _number;*/
                                                //Text_DateAndTimeNowCSR.text = dateTime; "Date and Time now:" + 
    }
}
