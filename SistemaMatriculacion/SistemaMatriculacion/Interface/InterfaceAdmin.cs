using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Interfaces
{
    interface IntefaceAdmin
    {
        bool insertarAdminInterface(EntidadAdmin entidadAdmin);
        bool actualizarAdminInterface(EntidadAdmin entidadAdmin);
        bool eliminarAdminInterface(int id);
        List<EntidadAdmin> leerAdminInterface();
        bool buscarAdminPorUsuaruio(EntidadAdmin entidadAdmin);
    }
}
