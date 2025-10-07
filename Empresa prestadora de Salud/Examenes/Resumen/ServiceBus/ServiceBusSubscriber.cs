using Resumen.Servicios;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumen.ServiceBus
{
    public class ServiceBusSubscriber
    {
        private readonly string _connectionString;
        private readonly string _topicName;
        private readonly string _subscriptionName;
        private readonly ServicioResumen _resumeService;

        public ServiceBusSubscriber(IConfiguration config, ServicioResumen resumeService)
        {
            _connectionString = config["AzureServiceBus:ConnectionString"]!;
            _topicName = config["AzureServiceBus:TopicName"]!;
            _subscriptionName = config["AzureServiceBus:SubscriptionName"]!;
            _resumeService = resumeService;
        }

        public async Task EscucharAsync()
        {
            await using var client = new ServiceBusClient(_connectionString);
            var processor = client.CreateProcessor(_topicName, _subscriptionName);

            processor.ProcessMessageAsync += async args =>
            {
                string body = args.Message.Body.ToString();

                // 👇 Lógica delegada al servicio
                _resumeService.VerResumen(body);

                await args.CompleteMessageAsync(args.Message);
            };

            processor.ProcessErrorAsync += args =>
            {
                Console.WriteLine($"Error en el suscriptor: {args.Exception.Message}");
                return Task.CompletedTask;
            };

            await processor.StartProcessingAsync();

            Console.WriteLine("Suscriptor de Resumen escuchando mensajes...");
            Console.ReadKey();
        }
    }
}

