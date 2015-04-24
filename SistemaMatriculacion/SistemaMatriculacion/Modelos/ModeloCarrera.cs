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

namespace com.SistemaMatriculacion.Modelos.Models
{
    class ModeloCarrera : InterfaceCarrera
    {
        private MySqlCommand cmd;
        private const string insertarCarrera = "Insert Into carrera(Nombre) Values(@Nombre)";
        private const string actualizarCarrera = "Update carrera Set Nombre = @Nombre Where Id = @Id";
        private const string eliminarCarrera = "Delete From carrera Where Id = @Id";
        private const string leerTodosCarrera = "Select * From carrera";
        private const string verificarCarrera = "Select * From carrera Where Nombre = @Nombre";

        private const string encontrarIdCarrera = "Select Id from carrera Where Nombre = @Nombre";

        private const string eliminarAlumnos = "Delete From alumnos Where Carrera_Id = @Carrera_Id";


        public bool insertarCarreraInterface(EntidadCarrera entidadCarrerar)
        {
            
                try
                {
                    Conexion.getConnection().Open();
                    cmd = Conexion.getConnection().CreateCommand();
                    cmd.CommandText = verificarCarrera;
                    cmd.Parameters.AddWithValue("@Nombre", entidadCarrerar.Nombre);
                    object res = cmd.ExecuteScalar();

                    if (res != null)
                    {
                        MessageBox.Show("Carrera encontrada en nuestra BD!");
                    }
                    else
                    {

                        cmd = Conexion.getConnection().CreateCommand();
                        cmd.CommandText = insertarCarrera;
                        cmd.Parameters.AddWithValue("@Nombre", entidadCarrerar.Nombre);
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


        public bool actualizarCarreraInterface(EntidadCarrera entidadCarrera, int id)
        {
            try
            {


                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = verificarCarrera;
                cmd.Parameters.AddWithValue("@Nombre", entidadCarrera.Nombre);
                object res = cmd.ExecuteScalar();

                if (res != null)
                {
                    MessageBox.Show("Carrera encontrada en nuestra BD!");
                }
                else
                {

                    cmd = Conexion.getConnection().CreateCommand();
                    cmd.CommandText = actualizarCarrera;
                    cmd.Parameters.AddWithValue("@Nombre", entidadCarrera.Nombre);
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

        public bool eliminarCarreraInterface(int id)
        {
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = eliminarAlumnos;
                cmd.Parameters.AddWithValue("@Carrera_Id", id);
                cmd.ExecuteNonQuery();

                
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = eliminarCarrera;
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

        public List<EntidadCarrera> leerTodasCarrerasInterface()
        {
            List<EntidadCarrera> listaCarreras = new List<EntidadCarrera>();
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = leerTodosCarrera;
                MySqlDataReader lector = cmd.ExecuteReader();
                while(lector.Read()){
                    EntidadCarrera entidadCarrera = new EntidadCarrera();
                    entidadCarrera.Id = Convert.ToInt32(lector[0].ToString());
                    entidadCarrera.Nombre = lector[1].ToString();

                    listaCarreras.Add(entidadCarrera);
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

            return listaCarreras;
        }



        public int encontrarCarreraPorIdInterface(EntidadCarrera entidadCarrera)
        {
            int sec = 0;
            try
            {
                Conexion.getConnection().Open();
                cmd = Conexion.getConnection().CreateCommand();
                cmd.CommandText = encontrarIdCarrera;
                cmd.Parameters.AddWithValue("@Nombre", entidadCarrera.Nombre);
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


