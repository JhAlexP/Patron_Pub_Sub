using Resumen.ServiceBus;
using Resumen.Servicios;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>() // 🔐 Lee secrets
    .Build();

var ResumenService = new ServicioResumen();
var subscriber = new ServiceBusSubscriber(config, ResumenService);

await subscriber.EscucharAsync();
