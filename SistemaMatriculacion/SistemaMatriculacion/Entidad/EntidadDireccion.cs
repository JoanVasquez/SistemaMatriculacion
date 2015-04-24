using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.SistemaMatriculacion.Entidades
{
    class EntidadDireccion
    {
        private int id;
        private string direccion;
        private string pais;
        private string estado;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
