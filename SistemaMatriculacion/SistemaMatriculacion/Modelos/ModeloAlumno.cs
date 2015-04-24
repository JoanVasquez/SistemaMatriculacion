using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace com.SistemaMatriculacion.Modelos.Models
{
    class ModeloAlumno : InterfaceAlumno{


        private MySqlCommand cmd;
        private const string leerTodosAlumnosQuery = @"select al.Id, al.Nombre, al.Apellidos, al.FechaNacimiento, al.Matricula, al.Contraseña, al.Ciclo, ca.Nombre as Carrera, di.Estado, di.Pais, di.Direccion 
                                                    from alumnos al 
                                                    inner join carrera ca on al.Carrera_Id = ca.Id 
                                                    inner join direccion di on al.Direccion_Id = di.Id Order by al.Id";

        private const string insertarAlumnosQuery = @"Insert Into alumnos(Nombre, Apellidos, FechaNacimiento, Ciclo, Contraseña, Matricula, Carrera_Id, 
                                                    Direccion_Id) Values(@Nombre, @Apellidos, @FechaNacimiento, @Ciclo, @Contraseña, @Matricula, @Carrera_Id, 
                                                    @Direccion_Id)";

        private const string actualizarAlumnosQuery = @"Update alumnos Set Nombre = @Nombre, Apellidos = @Apellidos, FechaNacimiento = @FechaNacimiento,
                                                      Ciclo = @Ciclo, Contraseña = @Contraseña, Matricula = @Matricula, Carrera_Id = @Carrera_Id, 
                                                      Direccion_Id = @Direccion_Id Where Id = @Id";

        private const string eliminarAlumnosQuery = "Delete From alumnos Where Id = @Id";

        private const string verificarAlumnosQuery = "Select * From alumnos Where Matricula = @Matricula";

        private const string secuenciaAlumnosMatriculasQuery = "select max(Id) as Id from alumnos";


        public bool insertarAlumnosInterface(EntidadAlumno entidadAlumno)
        {
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = verificarAlumnosQuery;
                cmd.Parameters.AddWithValue("@Matricula", entidadAlumno.Matricula);
                object res = cmd.ExecuteScalar();

                if (res != null)
                {
                    MessageBox.Show("Alumnos encontrado en nuestra BD!");
                }
                else
                {

                    cmd = Conexion.getConnection().CreateCommand();
                    cmd.CommandText = insertarAlumnosQuery;
                    cmd.Parameters.AddWithValue("@Nombre", entidadAlumno.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", entidadAlumno.Apellidos);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", entidadAlumno.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Ciclo", entidadAlumno.Ciclo);
                    cmd.Parameters.AddWithValue("@Contraseña", entidadAlumno.Contrasena);
                    cmd.Parameters.AddWithValue("@Matricula", entidadAlumno.Matricula);
                    cmd.Parameters.AddWithValue("@Carrera_Id", entidadAlumno.Carrera.Id);
                    cmd.Parameters.AddWithValue("@Direccion_Id", entidadAlumno.Direccion.Id);
                    cmd.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.ToString());
            }
            finally
            {
                Conexion.getClosedConnection();
            }
            
            return false;
        }

        public bool actualizarAlumnosInterface(EntidadAlumno entidadAlumno)
        {
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = verificarAlumnosQuery;
                cmd.Parameters.AddWithValue("@Matricula", entidadAlumno.Matricula);
                object res = cmd.ExecuteScalar();

                if (res != null)
                {
                    MessageBox.Show("Alumnos encontrado en nuestra BD!");
                }
                else
                {

                    cmd = Conexion.getConnection().CreateCommand();
                    cmd.CommandText = actualizarAlumnosQuery;
                    cmd.Parameters.AddWithValue("@Nombre", entidadAlumno.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", entidadAlumno.Apellidos);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", entidadAlumno.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Ciclo", entidadAlumno.Ciclo);
                    cmd.Parameters.AddWithValue("@Contraseña", entidadAlumno.Contrasena);
                    cmd.Parameters.AddWithValue("@Matricula", entidadAlumno.Matricula);
                    cmd.Parameters.AddWithValue("@Carrera_Id", entidadAlumno.Carrera.Id);
                    cmd.Parameters.AddWithValue("@Direccion_Id", entidadAlumno.Direccion.Id);
                    cmd.Parameters.AddWithValue("@Id", entidadAlumno.Id);
                    cmd.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.ToString());
            }
            finally
            {
                Conexion.getClosedConnection();
            }

            return false;
        }

        public bool eliminarAlumnosInterface(int id)
        {
            try
            {
                Conexion.getConnection().Open();
                
                

                    cmd = Conexion.getConnection().CreateCommand();
                    cmd.CommandText = eliminarAlumnosQuery;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    return true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.ToString());
            }
            finally
            {
                Conexion.getClosedConnection();
            }

            return false;
        }

        public List<EntidadAlumno> leerAlumnosInterface()
        {
            List<EntidadAlumno> listaAlumnos = new List<EntidadAlumno>();

            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = leerTodosAlumnosQuery;
                MySqlDataReader lector = cmd.ExecuteReader();
                while(lector.Read()){
                    EntidadAlumno entidadAlumno = new EntidadAlumno();
                    entidadAlumno.Id = Convert.ToInt32(lector[0].ToString());
                    entidadAlumno.Nombre = lector[1].ToString();
                    entidadAlumno.Apellidos = lector[2].ToString();
                    entidadAlumno.FechaNacimiento = Convert.ToDateTime(lector[3].ToString());
                    entidadAlumno.Matricula = Convert.ToInt32(lector[4].ToString());
                    entidadAlumno.Contrasena = lector[5].ToString();
                    entidadAlumno.Ciclo = lector[6].ToString();
                    entidadAlumno.Carrera.Nombre = lector[7].ToString();
                    entidadAlumno.Direccion.Estado = lector[8].ToString();
                    entidadAlumno.Direccion.Pais = lector[9].ToString();
                    entidadAlumno.Direccion.Direccion = lector[10].ToString();

                    listaAlumnos.Add(entidadAlumno);
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.ToString());
            }
            finally
            {
                Conexion.getClosedConnection();
            }


            return listaAlumnos;
        }

        public EntidadAlumno buscarAlumnosPorIdInterface(int id)
        {
            throw new NotImplementedException();
        }

        public int lastIdAlumnosInterface()
        {
                int sec = 0;
            try
            {
                
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = secuenciaAlumnosMatriculasQuery;
                object res = cmd.ExecuteScalar();
                
                if (res != null)
                {
                    sec = Convert.ToInt32(res);
                }
                
               return sec;

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error en: " + ex.ToString());
            }
            finally
            {
                Conexion.getClosedConnection();
            }
            return 0;
        }
    }
}