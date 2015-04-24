using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;
using com.SistemaMatriculacion.Modelos.Models;

namespace com.SistemaMatriculacion.Controlador
{
    class ControladorAlumno : InterfaceAlumno
    {
        private ModeloAlumno modeloAlumno = new ModeloAlumno();



        public bool insertarAlumnosInterface(EntidadAlumno entidadAlumno)
        {
           return modeloAlumno.insertarAlumnosInterface(entidadAlumno);
        }

        public bool actualizarAlumnosInterface(EntidadAlumno entidadAlumno)
        {
            return modeloAlumno.actualizarAlumnosInterface(entidadAlumno);
        }

        public bool eliminarAlumnosInterface(int id)
        {
            return modeloAlumno.eliminarAlumnosInterface(id);
        }

        public List<EntidadAlumno> leerAlumnosInterface()
        {
            return modeloAlumno.leerAlumnosInterface();
        }

        public EntidadAlumno buscarAlumnosPorIdInterface(int id)
        {
            throw new NotImplementedException();
        }

        public int lastIdAlumnosInterface()
        {
            return modeloAlumno.lastIdAlumnosInterface();
        }
    }
}
