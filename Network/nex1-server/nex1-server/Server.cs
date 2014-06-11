using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace nex1_server
{
    public class EchoServer
    {
        static byte[] buffer = new byte[1024];
        static void __Main(string[] args)
        {
            Console.Write("사용할 포트를 입력하세요(1024 - 65535)");
            int port = int.Parse(Console.ReadLine());
            IPEndPoint addr = new IPEndPoint(IPAddress.Any, port);
            TcpListener listener = new TcpListener(addr);
            listener.Start();
            Console.WriteLine("Server Start");
            
            while (true)
            {
                TcpClient cli = listener.AcceptTcpClient();
                Console.WriteLine("클라이언트 접속: {0}", cli.Client.RemoteEndPoint.ToString());
                NetworkStream ns = cli.GetStream();

                int len;
                string data;
                while ((len = ns.Read(buffer, 0, buffer.Length)) != 0)
                {
                    data = Encoding.UTF8.GetString(buffer, 0, len);
                    Console.WriteLine("수신: {0}" , data);
                    ns.Write(buffer, 0, len);
                }
                ns.Close();
                cli.Close();
            }
        }
    }
}
