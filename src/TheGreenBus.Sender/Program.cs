using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreenBus.Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Endpoint=sb://thegreenbus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=9os+TCEaZ/AjUXk3ZWJoAw944CJrcFIBOyCdLgX1XR8=";
            string queuename = "queuedemo";

            var client = QueueClient.CreateFromConnectionString(connectionString, queuename);
            var message = new BrokeredMessage("I'm on The Green Bus!");
            client.Send(message);

            Console.WriteLine("Message was successfully sent!");

            Console.ReadLine();
        }
    }
}
