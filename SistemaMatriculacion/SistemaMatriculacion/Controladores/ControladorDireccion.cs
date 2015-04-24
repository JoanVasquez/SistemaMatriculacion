using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Interfaces;
using System.Windows.Forms;
using com.SistemaMatriculacion.Entidades;
using com.SistemaMatriculacion.Modelos.Models;

namespace com.SistemaMatriculacion.Controlador
{
    class ControladorDireccion : InterfaceDireccion
    {

        private ModeloDireccion modeloDireccion = new ModeloDireccion();

        public bool insertarDireccionInterface(EntidadDireccion entidadDireccion)
        {
            return modeloDireccion.insertarDireccionInterface(entidadDireccion);
        }

        public bool actualizarDireccionInterface(EntidadDireccion entidadDireccion, int id)
        {
            return modeloDireccion.actualizarDireccionInterface(entidadDireccion, id);
        }

        public bool eliminarDireccionInterface(int id)
        {
            return modeloDireccion.eliminarDireccionInterface(id);
        }

        public List<EntidadDireccion> leerTodosDireccionInterface()
        {
            return modeloDireccion.leerTodosDireccionInterface();
        }

        public int encontrarDireccionPorIdInterface(EntidadDireccion entidadDireccion)
        {
            return modeloDireccion.encontrarDireccionPorIdInterface(entidadDireccion);
        }
    }
}
