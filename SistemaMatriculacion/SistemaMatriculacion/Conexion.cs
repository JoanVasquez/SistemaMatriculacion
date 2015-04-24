using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace com.SistemaMatriculacion.Modelos
{

    class Conexion
    {
        private static MySqlConnection cn;
        private static readonly object padlock = new object();

        //private Conexion();

        public static MySqlConnection getConnection()
        {
            lock (padlock)
            {
                if (cn == null)
                {
                    cn = new MySqlConnection("Server=localhost;Port=3306;Database=sistema_matriculacion;Uid=root;Password=pass2288");
                    //server=localhost;user id=root;database=sistema_matriculacion
                    //server=localhost;user id=root;database=pjhospital
                    //MessageBox.Show("`Conexion realizada con exito");
                }
                return cn;
            }
        }

        public static void getClosedConnection()
        {
            getConnection().Close();
        }
    }
    }

