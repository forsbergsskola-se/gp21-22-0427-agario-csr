using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using OpenWord_MMO;



    public static class Program
    {
        //( message;// = "";
        static void Main(string[] arguments)
        {
            var wordset = "";
            var serverEndpoint = new IPEndPoint(IPAddress.Loopback, 44444); //
            var server = new UdpClient(serverEndpoint);

            serverUDP networkMessage = new serverUDP();
            networkMessage.ConsMesage();

            while (true)
            {
                IPEndPoint? clientEP = default;
                var responseBytes = server.Receive(ref clientEP);
                string response = Encoding.ASCII.GetString(responseBytes).Trim();
                byte[] serverFeedback;

                try
                {
                    //Need to throw some kind of exception instead of my hacky way here I think...?
                    if (response.Length > 20 || response.Any(char.IsWhiteSpace))
                    {
                        Console.WriteLine("Please try again. Your word is too or there is more than one word.");
                        // serverFeedback = Encoding.ASCII.GetBytes("ERROR: Word is longer than 20 characters or contains whitespaces");
                        throw new Exception("Please try again. Your word is too or there is more than one word.");

                    }

                    wordset += " " + response;
                    Console.WriteLine($"Packets received from: {clientEP} saying: {wordset}");
                    serverFeedback = Encoding.ASCII.GetBytes(wordset);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }


                server.Send(serverFeedback, serverFeedback.Length, clientEP);
                server.Close();
            }
        }
    }
//new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Any(s => s.Length > 50);
    // networkMessage.Result = WordValidator.ProcessWord(response);

    /*
    if (networkMessage.Result.Error != Error.None) {
        SendNetworkMessage(networkMessage, server, clientEP);
        continue;
    }*/

    // Console.WriteLine($"Packet received from: {clientEP} saying: {response}");

    // networkMessage.Response += " " + response;
    // SendNetworkMessage(networkMessage, server, clientEP);



    /*public void SendNetworkMessage(serverUDP networkMessage, UdpClient? server, IPEndPoint? clientEP) {
    string messageJson = JsonSerializer.Serialize(networkMessage);
    byte[] messageBytes = Encoding.ASCII.GetBytes(messageJson);
    server?.Send(messageBytes, messageBytes.Length, clientEP);
    }*/

