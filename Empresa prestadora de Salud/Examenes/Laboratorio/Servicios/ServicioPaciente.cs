using Laboratorio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Servicios
{
    public class ServicioPaciente
    {
        private readonly List<Paciente> _pacientes = new();

        public void AgregarPaciente(Paciente paciente)
        {
            _pacientes.Add(paciente);
            Console.WriteLine($"✅ Paciente {paciente.Nombre} agregado.");
        }

        public IEnumerable<Paciente> ObtenerPacientes()
        {
            return _pacientes;
        }
    }
}
