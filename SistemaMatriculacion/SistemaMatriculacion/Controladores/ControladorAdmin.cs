using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Entidades;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Modelos.Models;


namespace com.SistemaMatriculacion.Controlador
{
    class ControladorAdmin : IntefaceAdmin
    {
        ModeloAdmin modeloAdmin = new ModeloAdmin();

        public bool insertarAdminInterface(EntidadAdmin entidadAdmin)
        {
            return modeloAdmin.insertarAdminInterface(entidadAdmin);
        }

        public bool actualizarAdminInterface(EntidadAdmin entidadAdmin)
        {
            return modeloAdmin.actualizarAdminInterface(entidadAdmin);
        }

        public bool eliminarAdminInterface(int id)
        {
            return modeloAdmin.eliminarAdminInterface(id);
        }

        public List<EntidadAdmin> leerAdminInterface()
        {
            return modeloAdmin.leerAdminInterface();
        }

        public bool buscarAdminPorUsuaruio(EntidadAdmin entidadAdmin)
        {
            return modeloAdmin.buscarAdminPorUsuaruio(entidadAdmin);
        }
    }
}
