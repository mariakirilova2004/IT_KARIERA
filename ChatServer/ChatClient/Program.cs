using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(hostName);
            IPAddress iPAddress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEndPoint = new IPEndPoint(iPAddress, port: 11000);

            Socket sender = new Socket(SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(remoteEndPoint);
                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                while (true)
                {
                    Console.Write("> ");
                    var message = Console.ReadLine();

                    byte[] msgBytes = Encoding.ASCII.GetBytes(message + "<EOF>");

                    int bytesSent = sender.Send(msgBytes);

                    if(message == "exit")
                    {
                        break;
                    }
                }

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}