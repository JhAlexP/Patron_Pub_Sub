using Azure.Messaging.ServiceBus;
using Laboratorio.Modelos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.ServiceBus
{
    public class ServiceBusPublisher
    {
        private readonly string _connectionString;
        private readonly string _topicName;

        public ServiceBusPublisher(IConfiguration config)
        {
            _connectionString = config["AzureServiceBus:ConnectionString"]!;
            _topicName = config["AzureServiceBus:TopicName"]!;       }
 

        public async Task EnviarMensajeAsync(Paciente paciente)
        {
            await using var client = new ServiceBusClient(_connectionString);
            var sender = client.CreateSender(_topicName);

            string body = $"Resultados Paciente {paciente.Nombre} Emitidos";
            var message = new ServiceBusMessage(body);

            await sender.SendMessageAsync(message);
            Console.WriteLine($"📤 Mensaje enviado: {body}");
        }
    }
}
