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
    public partial class frmRegistroProvedores : Form
    {
        public frmRegistroProvedores()
        {
            InitializeComponent();
        }

        private void frmRegistroProvedores_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            string archivoProveedor = "Listado de aseguradores.csv";
            dgvDatosRegistro.Rows.Clear();

            try
            {
                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] separador = readLine.Split(';');

                        foreach (string columna in separador)
                        {
                            dgvDatosRegistro.Columns.Add(columna, columna);
                        }

                        HashSet<string> jurisdiccionesUnicas = new HashSet<string>();
                        HashSet<string> responsablesUnicos = new HashSet<string>();
                        HashSet<string> juzgadosUnicos = new HashSet<string>();



                        while (!sr.EndOfStream)
                        {
                            readLine = sr.ReadLine();
                            separador = readLine.Split(';');
                            dgvDatosRegistro.Rows.Add(separador);

                            juzgadosUnicos.Add(separador[4]);
                            jurisdiccionesUnicas.Add(separador[5]);
                            responsablesUnicos.Add(separador[7]);

                        }

                        //Carga de jurisdiccions unicas sin repetir
                        foreach (string jurisdiccion in jurisdiccionesUnicas)
                        {
                            cmbJuzgado.Items.Add(jurisdiccion);
                        }

                        foreach (string responsable in responsablesUnicos)
                        {
                            cmbLiquidador.Items.Add(responsable);
                        }

                        foreach (string juzgado in juzgadosUnicos)
                        {
                            cmbJuzgado.Items.Add(juzgado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarGrilla()
        {
            dgvDatosRegistro.Rows.Clear();
        }

        private void txtNroRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNroRegistro.Text);
            string Entidad = txtEntidad.Text;
            int Expediente = int.Parse(txtNroExpediente.Text);
            string Juzgado = cmbJuzgado.Text;
            string Jurisdiccion = cmbJurisdiccion.Text;
            string Direccion = txtDireccion.Text;
            string Liquidador = cmbLiquidador.Text;
            DateTime fechaApertura = dtpApertura.Value;

            ClsRegistroProvedores registroProveedor = new ClsRegistroProvedores();
            //registroProveedor.Registrar(Numero, Entidad, fechaApertura, Expediente, Juzgado, Jurisdiccion, Direccion, Liquidador);
            cargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNroRegistro.Text);
            string Entidad = txtEntidad.Text;
            string Expediente = txtNroExpediente.Text;
            string Juzgado = cmbJuzgado.Text;
            string Jurisdiccion = cmbJurisdiccion.Text;
            string Direccion = txtDireccion.Text;
            string Liquidador = cmbLiquidador.Text;
            DateTime fechaApertura = dtpApertura.Value;
            ClsRegistroProvedores registroProveedor = new ClsRegistroProvedores();
            registroProveedor.Eliminar(Numero);
            cargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNroRegistro.Text);
            string Entidad = txtEntidad.Text;
            string Expediente = txtNroExpediente.Text;
            string Juzgado = cmbJuzgado.Text;
            string Jurisdiccion = cmbJurisdiccion.Text;
            string Direccion = txtDireccion.Text;
            string Liquidador = cmbLiquidador.Text;
            DateTime fechaApertura = dtpApertura.Value;
            ClsRegistroProvedores registroProveedor = new ClsRegistroProvedores();
            registroProveedor.Modificar(Numero, Entidad, fechaApertura, Expediente, Juzgado, Jurisdiccion, Direccion, Liquidador);
            cargarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
