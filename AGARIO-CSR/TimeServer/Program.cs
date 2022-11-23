using System.Net;
using System.Net.Sockets;
using System.Text;

TcpListener tcpListener = new TcpListener(IPAddress.Any, 44444);
tcpListener.Start();

Console.WriteLine("Connecting!");
            
while (true) 
            
{
    var tcpClient = tcpListener.AcceptTcpClient();
    Console.WriteLine(tcpClient);
    
    Console.WriteLine($"Client {tcpClient.Client.RemoteEndPoint} connected.");
                
    using var stream = tcpClient.GetStream();
            
    stream.Write(Encoding.ASCII.GetBytes($"Hi, this is Cecilijas TimeServer. The current Date & Time is: " + DateTime.Now));
                
    tcpClient.Close();
}