using System;
using System.Diagnostics;
using System.IO;

namespace MSMQService
{
    public class MSMQService : IMSMQService
    {
        public void SendToOutputWindow(string msg, DateTime sendDate)
        {
            Debug.WriteLine(msg + " Otrzymana: " + System.DateTime.Now + " Wysłana: " + sendDate);
        }

        private static readonly object SyncObject = new object();
        private static readonly TextWriter W = new StreamWriter("log.txt", true);

        public void SendLockMessage(string msg, DateTime sendDate)
        {
            lock (SyncObject)
            {
                W.WriteLine("Otrzymana: {0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                W.WriteLine("Wysłana {0} {1}", sendDate.ToLongTimeString(),
                    sendDate.ToLongDateString());
                W.WriteLine("  :");
                W.WriteLine("  :{0}", msg);
                W.WriteLine("-------------------------------");
                W.Flush();
            }
        }
    }
}
