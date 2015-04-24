using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Entidades;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace com.SistemaMatriculacion.Modelos
{
    class ModeloAdmin : IntefaceAdmin
    {
        private const string leerTodosAdminQuery = "Select * From Administracion";
        private const string insertarAdminQuery = "Insert into Administracion(Usuario, Contraseña) Values(@Usuario, @Contrasena)";
        private const string actualizaAdminQuery = "Update Administracion Set Usuario = @Usuario, Contrasena = @Contrasena Where Id = @Id";
        private const string eliminarAdminQuery = "Delete From Administracion Where Id = @Id";
        private const string checkIfExitAdminQuery = "Select * From Administracion Where Usuario = @Usuario";
        private MySqlCommand cmd;

        public bool insertarAdmin(EntidadAdmin entidadAdmin)
        {
            try
            {
                Conexion.getConexion().Open();
                cmd = Conexion.getConexion().CreateCommand();
                cmd.CommandText = checkIfExitAdminQuery;
                cmd.Parameters.AddWithValue("@Usuario", entidadAdmin.usuario);
                Object res = cmd.ExecuteScalar();

                if (res != null)
                {
                    MessageBox.Show("Nombre de usuario encontrado en nuestra BD!");
                }
                else
                {
                    cmd = Conexion.getConexion().CreateCommand();
                    cmd.CommandText = insertarAdminQuery;
                    cmd.Parameters.AddWithValue("@Usuario", entidadAdmin.usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", entidadAdmin.contrasena);
                    cmd.ExecuteNonQuery();

                    return true;
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

        public bool actualizarAdmin(EntidadAdmin entidadAdmin, int id)
        {
            try
            {
                Conexion.getConexion().Open();
                
                    cmd = Conexion.getConexion().CreateCommand();
                    cmd.CommandText = actualizaAdminQuery;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Usuario", entidadAdmin.usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", entidadAdmin.contrasena);
                    cmd.ExecuteNonQuery();

                    return true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido actualizar el Admin: " + ex.ToString());
            }
            finally
            {
                Conexion.getConexionClosed();
            }

            return false;
        }

        public bool eliminarAdmin(int id)
        {
            try
            {
                Conexion.getConexion().Open();

                cmd = Conexion.getConexion().CreateCommand();
                cmd.CommandText = eliminarAdminQuery;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar el Admin: " + ex.ToString());
            }
            finally
            {
                Conexion.getConexionClosed();
            }


            return false;
        }

        public void leerTodosAdmin(DataGridView adminTabla)
        {
            DataTable dtDatos = new DataTable();
            try
            {
                Conexion.getConexion().Open();

                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(leerTodosAdminQuery, Conexion.getConexion());

                mdaDatos.Fill(dtDatos);

                adminTabla.DataSource = dtDatos;
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

    }
}
