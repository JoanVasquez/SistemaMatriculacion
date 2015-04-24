using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Interfaces
{
    interface InterfaceMatricula
    {
        bool insetarMatricula(EntidadMatricula entidadMatricula);
        bool eliminarMatricula(int id);
        void leeMatriculas(DataGridView tablaMatriculas);
        int Secuencia();
    }
}
