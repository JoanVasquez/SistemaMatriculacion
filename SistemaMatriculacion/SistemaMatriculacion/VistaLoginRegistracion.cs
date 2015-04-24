using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.SistemaMatriculacion.Vistas
{
    public partial class VistaLoginRegistracion : Form
    {

        private VistaLogin vistaLogin;

        public VistaLoginRegistracion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtPass.Text)){
                if(txtUsuario.Text == "admin" && txtPass.Text == "administrador"){

                    VistaRegistrarse vistaRegistrarse = new VistaRegistrarse();
                   
                    this.Hide();
                    vistaRegistrarse.ShowDialog();
                    this.Close();

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            vistaLogin = new VistaLogin();
            this.Hide();
            vistaLogin.ShowDialog();
            this.Close();
        }
    }
}
