using Agendamiento.ServiceBus;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendamiento.Servicios
{
    public class ServicioAgendamiento
    {
        public void AgendarCita(string mensaje)
        {
            Console.WriteLine("Procesando agendamiento...\n");
            Console.WriteLine($"Mensaje recibido: {mensaje}\n");
            Console.WriteLine("Cita para lectura de resultados ha sido agendada correctamente.\n");
        }
    }
}
