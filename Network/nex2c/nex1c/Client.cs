using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
namespace nex1c
{
    public class Client
    {
        private Socket client;
        private NetworkStream ns;
        private byte[] buf = new byte[1024];
        public string Connect(string addr, int port)
        {
            IPEndPoint server = new IPEndPoint(IPAddress.Parse(addr), port);
            client = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
            try
            {
                client.Connect(server);
            } catch (Exception e)
            {                
                //오류 발생시 여기로
                return e.Message;       
            }
            //정상 접속
            ns = new NetworkStream(client);
            return "success";
        }

        public void Close()
        {
            ns.Close();
            client.Close();            
        }

        public string Send(string msg)
        {
            byte[] data = Encoding.UTF8.GetBytes(msg);
            ns.Write(data, 0, data.Length);
            int len = ns.Read(buf, 0, buf.Length);
            string ret = Encoding.UTF8.GetString(buf,0,len);
            return ret;
        }
    }
}
