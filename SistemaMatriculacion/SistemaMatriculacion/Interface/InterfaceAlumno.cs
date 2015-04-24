using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Interfaces
{
    interface InterfaceAlumno
    {

        bool insertarAlumnosInterface(EntidadAlumno entidadAlumno);
        bool actualizarAlumnosInterface(EntidadAlumno entidadAlumno);
        bool eliminarAlumnosInterface(int id);
        List<EntidadAlumno> leerAlumnosInterface();
        EntidadAlumno buscarAlumnosPorIdInterface(int id);
        int lastIdAlumnosInterface();
    }
}
