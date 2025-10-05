using Agendamiento.ServiceBus;
using Agendamiento.Servicios;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>() // 🔐 Lee secrets
    .Build();

var agendamientoService = new ServicioAgendamiento();
var subscriber = new ServiceBusSubscriber(config, agendamientoService);

await subscriber.EscucharAsync();

