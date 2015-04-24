using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.SistemaMatriculacion.Entidades
{
    class EntidadCarrera
    {
        private int id;
        private string nombre;

        
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
