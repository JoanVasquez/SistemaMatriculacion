using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Entidades;
using com.SistemaMatriculacion.Interfaces;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Modelos.Models
{
    class ModeloDireccion : InterfaceDireccion
    {

        private MySqlCommand cmd;
        private const string insertarDireccion = "Insert Into direccion(Direccion, Pais, Estado) Values(@Direccion, @Pais, @Estado)";
        private const string actualizarDireccion = "Update direccion Set Direccion = @Direccion, Pais = @Pais, Estado = @Estado Where Id = @Id";
        private const string eliminarDireccion = "Delete From direccion Where Id = @Id";
        private const string leerTodosDireccion = "Select * From direccion";
        private const string verificarDireccion = "Select * From direccion Where Direccion = @Direccion";

        private const string encontrarIdDireccion = "Select Id from direccion Where Direccion = @Direccion";

        private const string eliminarAlumnos = "Delete From alumnos Where Direccion_Id = @Direccion_Id";

        public bool insertarDireccionInterface(EntidadDireccion entidadDireccion)
        {
            try
            {


                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = verificarDireccion;
                cmd.Parameters.AddWithValue("@Direccion", entidadDireccion.Direccion);
                object res = cmd.ExecuteScalar();

                if (res != null)
                {
                    MessageBox.Show("Direccion encontrada en nuestra BD!");
                }
                else
                {

                    cmd = Conexion.getConnection().CreateCommand();
                    cmd.CommandText = insertarDireccion;
                    cmd.Parameters.AddWithValue("@Direccion", entidadDireccion.Direccion);
                    cmd.Parameters.AddWithValue("@Pais", entidadDireccion.Pais);
                    cmd.Parameters.AddWithValue("@Estado", entidadDireccion.Estado);
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

        public bool actualizarDireccionInterface(EntidadDireccion entidadDireccion, int id)
        {
            try
            {


                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = verificarDireccion;
                cmd.Parameters.AddWithValue("@Direccion", entidadDireccion.Direccion);
                object res = cmd.ExecuteScalar();

                if (res != null)
                {
                    MessageBox.Show("Direccion encontrada en nuestra BD!");
                }
                else
                {

                    cmd = Conexion.getConnection().CreateCommand();
                    cmd.CommandText = actualizarDireccion;
                    cmd.Parameters.AddWithValue("@Direccion", entidadDireccion.Direccion);
                    cmd.Parameters.AddWithValue("@Pais", entidadDireccion.Pais);
                    cmd.Parameters.AddWithValue("@Estado", entidadDireccion.Estado);
                    cmd.Parameters.AddWithValue("@Id", id);
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

        public bool eliminarDireccionInterface(int id)
        {
            try
            {
                
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = eliminarAlumnos;
                cmd.Parameters.AddWithValue("@Direccion_Id", id);
                cmd.ExecuteNonQuery();

                
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = eliminarDireccion;
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

        public List<EntidadDireccion> leerTodosDireccionInterface()
        {
            List<EntidadDireccion> listaDirecciones = new List<EntidadDireccion>();

            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = leerTodosDireccion;
                MySqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    EntidadDireccion entidadDireccion = new EntidadDireccion();
                    entidadDireccion.Id = Convert.ToInt32(lector[0].ToString());
                    entidadDireccion.Direccion = lector[1].ToString();
                    entidadDireccion.Pais = lector[2].ToString();
                    entidadDireccion.Estado = lector[3].ToString();

                    listaDirecciones.Add(entidadDireccion);
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
            return listaDirecciones;
        }

        public int encontrarDireccionPorIdInterface(EntidadDireccion entidadDireccion)
        {
            int sec = 0;
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = encontrarIdDireccion;
                cmd.Parameters.AddWithValue("@Direccion", entidadDireccion.Direccion);
                
                sec = Convert.ToInt32(cmd.ExecuteScalar());
                
                return sec;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en: " + ex.ToString());
            }
            finally
            {
                Conexion.getClosedConnection();
            }
            return sec;
        }
    }
}
