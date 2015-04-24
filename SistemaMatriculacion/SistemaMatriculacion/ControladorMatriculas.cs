using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Entidades;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Modelos;

namespace com.SistemaMatriculacion.Controlador
{
    class ControladorMatriculas : InterfaceMatricula
    {
        ModeloMatriculas mod = new ModeloMatriculas();
        public bool insetarMatricula(EntidadMatricula entidadMatricula)
        {
            return mod.insetarMatricula(entidadMatricula);
        }

        public bool eliminarMatricula(int id)
        {
            return mod.eliminarMatricula(id);
        }

        public void leeMatriculas(System.Windows.Forms.DataGridView tablaMatriculas)
        {
            mod.leeMatriculas(tablaMatriculas);
        }

        public int Secuencia()
        {
            mod.Secuencia();
            return 0;
        }
    }
}
