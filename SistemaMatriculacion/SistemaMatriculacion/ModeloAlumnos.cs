using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace com.SistemaMatriculacion.Modelos
{
    class ModeloAlumnos : InterfaceAlumnos
    {
        private const string insertarAlumnosQuery = "Insert Into alumnos(Nombre, Apellidos, FechaNacimiento, Carrera, Contraseña, Matriculas_Id, Direccion_Id)Values(@Nombre, @Apellidos, @FechaNamiento, @Carrera, @Contraseña, @Matricula, Direccion)";
        private const string matricualId = "Select Id From matriculas Where Nombre = @Nombre";
        private const string direccionId = "Select Id From direccion Where Id = @Id";
        private const string checkIfAlumnoExisteQuery = "Select * From alumnos Where Matriculas_Id = @Matriculas_Id";
        private MySqlCommand cmd;

        public bool insertar(EntidadAlumnos entidadAlumnos)
        {

            try
            {
                Conexion.getConexion().Open();
                cmd = Conexion.getConexion().CreateCommand();
                cmd.CommandText = checkIfAlumnoExisteQuery;
                cmd.Parameters.AddWithValue("@Matriculas_Id", entidadAlumnos.matricula.matricula);
                Object res = cmd.ExecuteScalar();
                
                if (res != null)
                {
                    MessageBox.Show("Matricula encontrada en nuestra BD, por favor crear matricula nueva!!");
                }
                else
                {
                    
                    cmd = Conexion.getConexion().CreateCommand();

                    cmd.CommandText = matricualId;
                    cmd.Parameters.AddWithValue("@Nombre", 1420150);
                    MySqlDataReader idM = cmd.ExecuteReader();

                    if (idM.Read())
                    {

                        int id_M = Convert.ToInt32(idM["Id"]);
                        idM.Close();

                        cmd = Conexion.getConexion().CreateCommand();
                        cmd.CommandText = direccionId;
                        cmd.Parameters.AddWithValue("@Id", 1);


                        MySqlDataReader idD = cmd.ExecuteReader();
                        

                        if (idD.Read())
                        {
                            int id_D = Convert.ToInt32(idD["Id"]);
                            idD.Close();

                            MessageBox.Show(id_M.ToString());
                            MessageBox.Show(id_D.ToString());

                            return true;
                        }
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido insertar el Admin: " + ex.ToString());
            }
            finally
            {
                Conexion.getConexionClosed();
            }
            return false;
        }

        public bool actualizar(EntidadAlumnos entidadAlumnos, int id)
        {

            return false;
        }

        public bool eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void leer(DataGridView tablaMatriculacion)
        {
            throw new NotImplementedException();
        }
    }
}
