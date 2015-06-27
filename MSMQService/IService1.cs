using System;
using System.ServiceModel;

namespace MSMQService
{
    [ServiceContract]
    public interface IMSMQService
    {
        [OperationContract(IsOneWay = true)]
        void SendLockMessage(string msg, DateTime sendDate);

        [OperationContract(IsOneWay = true)]
        void SendToOutputWindow(string msg, DateTime sendDate);

    }
}
