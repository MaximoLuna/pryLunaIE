using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryLunaIE
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        int Intentos = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;

            if (ClsUser.Login(Usuario, Contraseña))
            {

                ClsUser UsuarioActual = new ClsUser
                {
                    User = Usuario,
                    Password = Contraseña
                };

                UsuarioActual.UserName = Usuario;

                ClsUser.RegisterLog(Usuario);
                MessageBox.Show("Inicio de sesión válido.", "Bienvenido", MessageBoxButtons.OK);
                this.Hide();
                frmMain forMain = new frmMain(UsuarioActual);
                forMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Intentos++;
                MessageBox.Show(Intentos + " de 3 intentos");
                clearText();

                if (Intentos >= 3)
                {
                    MessageBox.Show("Usted se ha quedado sin intentos, por favor espere " + (Contador.Interval / 1000) + " segundos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Enabled = false;
                    txtContraseña.Enabled = false;
                    btnLogin.Enabled = false;

                    Contador.Tick += Contador_Tick;
                    Contador.Start();
                }
            }
        }

        public void clearText()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }

        private void Contador_Tick(object sender, EventArgs e)
        {
            // Habilitar el botón y detener el temporizador.
            Intentos = 0;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            btnLogin.Enabled = true;
            Contador.Stop();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtContraseña.Enabled = true;
            }
            else
            {
                txtContraseña.Enabled = false;
            }
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
