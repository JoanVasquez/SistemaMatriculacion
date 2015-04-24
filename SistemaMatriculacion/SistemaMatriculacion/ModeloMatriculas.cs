using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;
using System.Data;

namespace com.SistemaMatriculacion.Modelos
{
    class ModeloMatriculas : InterfaceMatricula
    {
        private const string insertarMatriculaQuery = "Insert Into Matriculas(Nombre) Values(@Nombre)";
        private const string leerTodasMatriculaQuery = "Select * From Matriculas";
        private const string eliminarMatriculaQuery = "Delete From Matriculas Where Id = @Id";
        private const string leerSecuenciasMatriculaQuery = "Select Id From Matriculas ORDER by Id DESC LIMIT 1";
        private MySqlCommand cmd;



        public bool insetarMatricula(EntidadMatricula entidadMatricula)
        {
            try
            {
                Conexion.getConexion().Open();

                cmd = Conexion.getConexion().CreateCommand();
                cmd.CommandText = insertarMatriculaQuery;
                cmd.Parameters.AddWithValue("@Nombre", entidadMatricula.matricula);
                cmd.ExecuteNonQuery();

                return true;
            }


            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido insertar la matricula: " + ex.ToString());
            }
            finally
            {
                Conexion.getConexionClosed();
            }
            return false;
        }

        public bool eliminarMatricula(int id)
        {
            try
            {
                Conexion.getConexion().Open();

                cmd = Conexion.getConexion().CreateCommand();
                cmd.CommandText = eliminarMatriculaQuery;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                return true;
            }


            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido insertar la matricula: " + ex.ToString());
            }
            finally
            {
                Conexion.getConexionClosed();
            }

            return false;
        }

        public void leeMatriculas(DataGridView tablaMatriculas)
        {

            DataTable dtDatos = new DataTable();
            try
            {
                Conexion.getConexion().Open();

                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(leerTodasMatriculaQuery, Conexion.getConexion());

                mdaDatos.Fill(dtDatos);

                tablaMatriculas.DataSource = dtDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer las provincias: " + ex.ToString());
            }
            finally
            {
                Conexion.getConexionClosed();
            }

        }

        public int Secuencia()
        {
            try
            {
                Conexion.getConexion().Open();

                cmd = Conexion.getConexion().CreateCommand();
                cmd.CommandText = leerSecuenciasMatriculaQuery;
                int sec = cmd.ExecuteNonQuery();

                return sec;
            }


            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido insertar la matricula: " + ex.ToString());
            }
            finally
            {
                Conexion.getConexionClosed();
            }
            return 0;
        }
    }
}
