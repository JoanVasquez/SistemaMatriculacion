using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Interfaces
{
    interface InterfaceCarrera
    {
        bool insertarCarreraInterface(EntidadCarrera entidadCarrerar);
        bool actualizarCarreraInterface(EntidadCarrera entidadCarrera, int id);
        bool eliminarCarreraInterface(int id);
        int encontrarCarreraPorIdInterface(EntidadCarrera entidadCarrera);
        List<EntidadCarrera> leerTodasCarrerasInterface();
    }
}
