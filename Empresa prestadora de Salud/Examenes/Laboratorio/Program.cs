using Laboratorio.Modelos;
using Laboratorio.ServiceBus;
using Laboratorio.Servicios;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>() // 👈 Lee secrets
    .Build();

var pacienteService = new ServicioPaciente();
var publisher = new ServiceBusPublisher(config);

while (true)
{
    Console.WriteLine("\n--- Ingreso de datos del paciente ---");

    var paciente = new Paciente
    {
        DocumentoID = Pedir("Documento ID"),
        Nombre = Pedir("Nombre"),
        Edad = int.Parse(Pedir("Edad")),
        Sexo = Pedir("Sexo"),
        GrupoSanguineo = Pedir("Grupo sanguíneo"),
        TelMovil = Pedir("Teléfono móvil"),
        Email = Pedir("Email"),
        TipoExamen = Pedir("Tipo de examen"),
        ResultadoExamen = Pedir("Resultado del examen")
    };

    pacienteService.AgregarPaciente(paciente);

    // Enviar al topic
    await publisher.EnviarMensajeAsync(paciente);

    Console.WriteLine("¿Desea ingresar otro paciente? (s/n): ");
    if (Console.ReadLine()?.ToLower() != "s")
        break;
}

// Mostrar todos los pacientes ingresados
Console.WriteLine("\n=== Lista de pacientes almacenados ===");
foreach (var p in pacienteService.ObtenerPacientes())
{
    Console.WriteLine($"- {p.Nombre}, {p.TipoExamen}: {p.ResultadoExamen}");
}

static string Pedir(string campo)
{
    Console.Write($"{campo}: ");
    return Console.ReadLine() ?? "";
}