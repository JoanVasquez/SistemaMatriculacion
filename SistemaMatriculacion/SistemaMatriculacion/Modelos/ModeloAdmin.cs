using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.SistemaMatriculacion.Interfaces;
using com.SistemaMatriculacion.Entidades;
using MySql.Data.MySqlClient;
using com.SistemaMatriculacion.Modelos;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Modelos.Models
{
    class ModeloAdmin : IntefaceAdmin
    {

        private MySqlCommand cmd;
        private const string insertarUsuario = "Insert Into administracion(Email, Contraseña) Values(@Email, @Contraseña)";
        private const string actualizarUsuario = "Update administracion Set Email = @Email, Contraseña = @Contraseña Where Id = @Id";
        private const string leerTodosUsuarios = "Select * From administracion";
        private const string verificarUsuario = "Select * From administracion Where Email = @Email";

        private const string encontrarUsuario = "Select * from administracion Where Email = @Email and Contraseña = @Contraseña";

        private const string eliminarUsuario = "Delete From administracion Where Id = @Id";

        public bool insertarAdminInterface(EntidadAdmin entidadAdmin)
        {
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = verificarUsuario;
                cmd.Parameters.AddWithValue("@Email", entidadAdmin.Email);
                object res = cmd.ExecuteScalar();

                if (res != null)
                {
                    MessageBox.Show("Usuario encontrado!");
                }
                else
                {

                    cmd = Conexion.getConnection().CreateCommand();
                    cmd.CommandText = insertarUsuario;
                    cmd.Parameters.AddWithValue("@Email", entidadAdmin.Email);
                    cmd.Parameters.AddWithValue("@Contraseña", entidadAdmin.Pass);
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

        public bool actualizarAdminInterface(EntidadAdmin entidadAdmin)
        {
            try
            {


                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = verificarUsuario;
                cmd.Parameters.AddWithValue("@Email", entidadAdmin.Email);
                object res = cmd.ExecuteScalar();

                if (res != null)
                {
                    MessageBox.Show("Usuario encontrado!");
                }
                else
                {

                    cmd = Conexion.getConnection().CreateCommand();
                    cmd.CommandText = actualizarUsuario;
                    cmd.Parameters.AddWithValue("@Email", entidadAdmin.Email);
                    cmd.Parameters.AddWithValue("@Contraseña", entidadAdmin.Pass);
                    cmd.Parameters.AddWithValue("@Id", entidadAdmin.Id);
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

        public bool eliminarAdminInterface(int id)
        {
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = eliminarUsuario;
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

        public List<EntidadAdmin> leerAdminInterface()
        {
            List<EntidadAdmin> listaUsuarios = new List<EntidadAdmin>();
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = leerTodosUsuarios;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    EntidadAdmin entidadAdmin = new EntidadAdmin();
                    entidadAdmin.Id = Convert.ToInt32(lector[0].ToString());
                    entidadAdmin.Email = lector[1].ToString();
                    entidadAdmin.Pass = lector[2].ToString();

                    listaUsuarios.Add(entidadAdmin);
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

            return listaUsuarios;
        }

        public bool buscarAdminPorUsuaruio(EntidadAdmin entidadAdmin)
        {
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = encontrarUsuario;
                cmd.Parameters.AddWithValue("@Email", entidadAdmin.Email);
                cmd.Parameters.AddWithValue("@Contraseña", entidadAdmin.Pass);
                object res = cmd.ExecuteScalar();

                if (res != null)
                {
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
    }
}
