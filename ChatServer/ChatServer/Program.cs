using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(hostName);
            IPAddress iPAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(iPAddress, port: 11000);

            Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp);

            try
            {
                byte[] buffer = new byte[1024];

                listener.Bind(localEndPoint);
                listener.Listen(100);

                Socket handle = listener.Accept();

                while (true)
                {
                    string message = "";

                    while (true)
                    {
                        var messageSize = handle.Receive(buffer);
                        message += Encoding.ASCII.GetString(buffer, 0, messageSize);

                        if (message.Contains("<EOF>"))
                        {
                            message = message.Replace("<EOF>", "");
                            break;
                        }
                    }

                    Console.WriteLine("> " + message);

                    if(message == "exit")
                    {
                        handle.Shutdown(SocketShutdown.Both);
                        handle.Close();
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}