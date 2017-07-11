using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreenBus.Receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Endpoint=sb://thegreenbus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=9os+TCEaZ/AjUXk3ZWJoAw944CJrcFIBOyCdLgX1XR8=";
            string queueName = "queuedemo";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);

            client.OnMessage(message =>
            {
                Console.WriteLine(String.Format("Message body: {0}", message.GetBody<String>()));
                Console.WriteLine(String.Format("Message id: {0}", message.MessageId));
            });

            Console.WriteLine("Press ENTER to exit program");
            Console.ReadLine();
        }
    }
}
