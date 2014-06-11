using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
namespace nex1_server
{
    class Client
    {
        static byte[] buf = new byte[1024];
        static void Main()
        {
            Console.Write("서버주소 :");
            string addr = Console.ReadLine();
            Console.Write("포트 :");
            int port = int.Parse(Console.ReadLine());

            IPEndPoint cpoint = new IPEndPoint(IPAddress.Parse(addr), port);
            TcpClient cli = new TcpClient();
            cli.Connect(cpoint);


            NetworkStream stream = cli.GetStream();

            Console.WriteLine("클라이언트 접속");
            string msg;

            while (true)
            {
                Console.WriteLine("메시지를 입력하세요. 종료는 !bye");
                msg = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(msg);
                stream.Write(data, 0, data.Length);
                int len = stream.Read(buf, 0, buf.Length);
                msg = Encoding.UTF8.GetString(buf, 0, len);
                Console.WriteLine("수신: {0}", msg);
            }
            stream.Close();
            cli.Close();
        }
    }
}
