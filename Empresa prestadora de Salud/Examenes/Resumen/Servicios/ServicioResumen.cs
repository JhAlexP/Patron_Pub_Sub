using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumen.Servicios
{
    public class ServicioResumen
    {
        public void VerResumen(string mensaje)
        {
            Console.WriteLine("Consultando datos...\n");
            Console.WriteLine($"Mensaje recibido: {mensaje} \n");
            Console.WriteLine("Los resultados de los examenes ya estan disponibles.\n");
        }
    }
}
