using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Common;
using System.Net.Sockets;
using System.IO;

namespace View.Communication
{
    public class CommunicationClient
    {
        private Receiver receiver;
        private Sender sender;
        public CommunicationClient(Socket socket)
        {
            receiver = new Receiver(socket);
            sender = new Sender(socket);
        }

        public void SendRequest(Request request)
        {
            try
            {
                sender.Send(request);
            }
            catch (IOException)
            {
                throw new Exception("Doslo je do greske sa serverom");
                
            }
            catch (SocketException)
            {
                
                throw new Exception("Doslo je do greske sa serverom");
            }
        }
        public object GetResponseResult()
        {
            Response response = (Response)receiver.Receive();
            if (response.IsSuccessful)
            {
                return response.Result;
            }
            else
            {
                throw new Exception(response.Error);
            }
        }
    }
}
