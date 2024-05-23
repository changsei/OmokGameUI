using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Message = Model.Message;

namespace Socket_Handler
{
    public class ClientSocketHandler : SocketHandler
    {
        public override void Parse(string jsonString)
        {
            Message message = ConvertToMessage(jsonString);

            if (message.RequestType.Equals("CONNECT"))
            {
                Send(CreateTheData(message));
                return;
            }

            if (message.RequestType.Equals("LOGIN_RESPONSE"))
            {
                this.Name = message.Name;
                EnqueueMessage(message);
                return;
            }

            if (message.RequestType.Equals("SEARCH_RESPONSE"))
            {
                this.Name = message.Name;
                EnqueueMessage(message);
                return;
            }

            if (message.RequestType.Equals("REGIST_RESPONSE"))
            {
                this.Name = message.Name;
                EnqueueMessage(message);
                return;
            }

            if (message.RequestType.Equals("UNREGIST_RESPONSE"))
            {
                this.Name = message.Name;
                EnqueueMessage(message);
                return;
            }

            EnqueueMessage(message);
        }
    }
}
