using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP_Receiver
{
    class Program
    {
        static void Main()
        {
            UdpClient MyClient = new UdpClient(10000);
            IPEndPoint MyEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                Byte[] bytes = MyClient.Receive(ref MyEndPoint);
                string message = Encoding.ASCII.GetString(bytes);
                Console.WriteLine("You received: " + message.ToString());
            }
        }
    }
}
