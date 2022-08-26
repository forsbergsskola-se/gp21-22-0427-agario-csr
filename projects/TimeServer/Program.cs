using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TimeServerCSR
{
    class Program
    
    {
        private static void Main(string[] args) 
        
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Ceci is:, 55.1967.0.8);
            tcpListener.Start();
            
            Console.WriteLine("Hallo Ceci!");
            
            while (true) 
            
            {
                var tcpClient = tcpListener.AcceptTcpClient();
                
                Console.WriteLine("Waiting for connection...");
                
                var stream = tcpClient.GetStream();
            
                stream.Write(Encoding.GetBytes.ASCII ($"Client {CeciID} connected"));
                
                tcpClient.Close();
            }
        }
    }
}