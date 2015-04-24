using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;
using com.SistemaMatriculacion.Modelos;

namespace com.SistemaMatriculacion.Controlador
{
    class ControladorAlumnos : InterfaceAlumnos
    {
        private ModeloAlumnos modeloAlumnos = new ModeloAlumnos();



        public bool insertar(EntidadAlumnos entidadAlumnos)
        {
            return modeloAlumnos.insertar(entidadAlumnos);
        }

        public bool actualizar(EntidadAlumnos entidadAlumnos, int id)
        {
            return modeloAlumnos.actualizar(entidadAlumnos, id);
        }

        public bool eliminar(int id)
        {
            return modeloAlumnos.eliminar(id);
        }

        public void leer(DataGridView tablaMatriculacion)
        {
            modeloAlumnos.leer(tablaMatriculacion);
        }
    }
}
