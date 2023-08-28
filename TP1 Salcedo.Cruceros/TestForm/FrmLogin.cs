using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TestForm
{
    public partial class FrmLogin : Form
    {
        Usuario user;

        public FrmLogin()
        {
            Datos.HardcodearUsuarios();
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.txtBoxContrasenia.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            string usuario = this.txtBoxUsuario.Text;
            string contrasenia = this.txtBoxContrasenia.Text;

            // Usuario usuarioALoguear = VerificarPassword(contrasenia);
            user = new Usuario(usuario, contrasenia, true);

            if (user.VerificarPassword(Datos.usuariosHardcodeados,contrasenia,usuario))
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(user);
              //  frmMenuPrincipal.Show();
                this.Hide();
                if (frmMenuPrincipal.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            //if (usuario == "tomassalcedo" && contrasenia == "123456")
            //{
            //    FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            //    frmMenuPrincipal.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.txtBoxUsuario.Text = "TomasElCreador";
            this.txtBoxContrasenia.Text = "booyaca619";
        }

        private void chkBoxMostrarPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxMostrarPassword.CheckState == CheckState.Checked)
            {
                this.txtBoxContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtBoxContrasenia.UseSystemPasswordChar = true;
            }
           
        }

        
    }
}
