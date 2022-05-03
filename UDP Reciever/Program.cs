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
            int port = 31090;

            UdpClient MyClient = new UdpClient(port);
            IPEndPoint MyEndPoint = new IPEndPoint(IPAddress.Any, 0);

            Console.WriteLine("Receiving on port: " + port.ToString());

            while (true)
            {
                Byte[] bytes = MyClient.Receive(ref MyEndPoint);
                string message = Encoding.ASCII.GetString(bytes);
                Console.WriteLine("You received: " + message.ToString());
            }
        }
    }
}
