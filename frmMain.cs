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
    internal partial class frmMain : Form
    {
        public ClsUser UsuarioActual;

        public frmMain(ClsUser UsuarioActual)
        {
            InitializeComponent();

            if (UsuarioActual != null)
            {
                this.UsuarioActual = UsuarioActual; // Usa 'this' para referenciar la variable miembro
            }
            else
            {
                // Maneja el caso en el que usuarioActual sea null si es necesario
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (UsuarioActual != null)
            {
                lblUserMain.Text = UsuarioActual.UserName;
            }
        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuActivo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        int Contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Contador += 1;

            if (Contador > 1)
            {
                lblDateMenu.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            }
        }

        private void lblUserTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void activosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //registro de log
            StreamWriter sw = new StreamWriter("logGeneral", true);

            sw.WriteLine(lblUserMain.Text + " - Fecha: " + DateTime.Now + " - Accede: " + activosToolStripMenuItem.Text);

            sw.Close();

            frmRegistroProvedores f = new frmRegistroProvedores();
            f.ShowDialog();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProvedores fProveedor = new frmRegistroProvedores();
            fProveedor.ShowDialog();

            //Registro
            StreamWriter sw = new StreamWriter("logGeneral", true);

            sw.WriteLine(lblUserMain.Text + " - Fecha: " + DateTime.Now + " - Accede: " + registroProveedoresToolStripMenuItem.Text);

            sw.Close();
        }
    }
}
