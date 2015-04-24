using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Interfaces
{
    interface InterfaceDireccion
    {
        bool insertarDireccionInterface(EntidadDireccion entidadDireccion);
        bool actualizarDireccionInterface(EntidadDireccion entidadDireccion, int id);
        bool eliminarDireccionInterface(int id);
        int encontrarDireccionPorIdInterface(EntidadDireccion entidadDireccion);
        List<EntidadDireccion> leerTodosDireccionInterface();
    }
}
