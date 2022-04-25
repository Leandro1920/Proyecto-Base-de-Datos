using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionBD.BLL
{
    internal class EmpleadosBLL
    {
        public int ID { get; set; }
        public string NombreEmpleado { get; set; }
        public string Apellidos { get; set; }
        public string Departamento { get; set; }
        public string Correo { get; set; }
        public Byte[] FotoEmpleado { get; set; }
    }
}
