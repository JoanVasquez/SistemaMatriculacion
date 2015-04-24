using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.SistemaMatriculacion.Entidades
{
    class EntidadAlumno
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        private string ciclo;

        public string Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }
        private int matricula;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private EntidadDireccion direccion = new EntidadDireccion();

        internal EntidadDireccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private EntidadCarrera carrera = new EntidadCarrera();

        internal EntidadCarrera Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        

        

    }
}
