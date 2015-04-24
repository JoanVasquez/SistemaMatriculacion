using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Modelos.Models;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Controlador
{
    class ControladorCarrera : InterfaceCarrera
    {
        private ModeloCarrera modeloCarrera = new ModeloCarrera();

        public bool insertarCarreraInterface(EntidadCarrera entidadCarrerar)
        {
            return modeloCarrera.insertarCarreraInterface(entidadCarrerar);
        }

        public bool actualizarCarreraInterface(EntidadCarrera entidadCarrera, int id)
        {
            return modeloCarrera.actualizarCarreraInterface(entidadCarrera, id);
        }

        public bool eliminarCarreraInterface(int id)
        {
            return modeloCarrera.eliminarCarreraInterface(id);
        }

        public List<EntidadCarrera> leerTodasCarrerasInterface()
        {
            return modeloCarrera.leerTodasCarrerasInterface();
        }

        public int encontrarCarreraPorIdInterface(EntidadCarrera entidadCarrera)
        {
            return modeloCarrera.encontrarCarreraPorIdInterface(entidadCarrera);
        }
    }
}
