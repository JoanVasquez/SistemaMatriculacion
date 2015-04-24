using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Entidades;
using com.SistemaMatriculacion.Modelos;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Controlador
{
    class ControladorAdmin : IntefaceAdmin
    {
        private ModeloAdmin modelAdmin = new ModeloAdmin();

        public bool insertarAdmin(EntidadAdmin entidadAdmin)
        {
            return modelAdmin.insertarAdmin(entidadAdmin);
        }

        public bool actualizarAdmin(EntidadAdmin entidadAdmin, int id)
        {
            return modelAdmin.actualizarAdmin(entidadAdmin, id);
        }

        public bool eliminarAdmin(int id)
        {
            return modelAdmin.eliminarAdmin(id);
        }

        public void leerTodosAdmin(DataGridView adminTabla)
        {
            modelAdmin.leerTodosAdmin(adminTabla);
        }

    }
}
