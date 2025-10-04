using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Modelos
{
    public class Paciente
    {
        public string DocumentoID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string GrupoSanguineo { get; set; }
        public string TelMovil { get; set; }
        public string Email { get; set; }
        public string TipoExamen { get; set; }
        public string ResultadoExamen { get; set; }
    }
}
