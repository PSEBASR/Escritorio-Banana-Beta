using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banana.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /*Programando los botnes*/
        private void ButtonGeneral(object sender, EventArgs e)
        {
            Button btn;
            btn = sender as Button;
            switch (btn.Name)
            {
                case "btnSalir":
                    this.Close();
                    break;
                case "btnLogin":
                    this.Validacion();
                    break;

            }
        }
        /*Validando Login*/
        public void Validacion()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("El campo contraseña esta vacio.");
                return;
            }
            else if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El campo usuario esta vacio.");
                return;
            }
            
        }


    }
}
