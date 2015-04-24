using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Interfaces
{
    interface InterfaceAlumnos
    {

        bool insertar(EntidadAlumnos entidadAlumnos);
        bool actualizar(EntidadAlumnos entidadAlumnos, int id);
        bool eliminar(int id);
        void leer(DataGridView tablaMatriculacion);
    }
}
