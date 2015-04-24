using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.SistemaMatriculacion.Entidades
{
    class EntidadAlumnos
    {
        public virtual string nombre { get; set; }
        public virtual string apellidos { get; set; }
        public virtual DateTime fechaNacimiento { get; set; }
        public virtual string carrera { get; set; }
        public virtual string ciclo { get; set; }
        public virtual EntidadDireccion direccion { get; set; }
        public virtual EntidadMatricula matricula { get; set; }
    }
}
