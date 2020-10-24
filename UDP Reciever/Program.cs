using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP_Reciever
{
    class Program
    {
        static void Main()
        {
            UdpClient receivingUdpClient = new UdpClient(10000);
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                Byte[] receiveBytes = receivingUdpClient.Receive(ref RemoteIpEndPoint);

                string message = Encoding.ASCII.GetString(receiveBytes);

                Console.WriteLine("You received: " + message.ToString());
            }
        }
    }
}
