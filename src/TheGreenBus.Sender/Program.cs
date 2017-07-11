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
            string queueName = "queuedemo";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            var message = new BrokeredMessage("{'id':'1','value':'On the Bus!'}") { ContentType = "application/json" };
            client.Send(message);

            Console.WriteLine("Message was successfully sent!");

            Console.WriteLine("Press ENTER to exit program");
            Console.ReadLine();
        }
    }
}
