namespace pryLunaIE
{
    partial class frmRegistroProvedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.dtpApertura = new System.Windows.Forms.DateTimePicker();
            this.cmbJuzgado = new System.Windows.Forms.ComboBox();
            this.cmbLiquidador = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtNroExpediente = new System.Windows.Forms.TextBox();
            this.txtNroRegistro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvDatosRegistro = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbJurisdiccion = new System.Windows.Forms.ComboBox();
            this.mrcRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.label8);
            this.mrcRegistro.Controls.Add(this.cmbJurisdiccion);
            this.mrcRegistro.Controls.Add(this.dtpApertura);
            this.mrcRegistro.Controls.Add(this.cmbJuzgado);
            this.mrcRegistro.Controls.Add(this.cmbLiquidador);
            this.mrcRegistro.Controls.Add(this.txtDireccion);
            this.mrcRegistro.Controls.Add(this.txtEntidad);
            this.mrcRegistro.Controls.Add(this.txtNroExpediente);
            this.mrcRegistro.Controls.Add(this.txtNroRegistro);
            this.mrcRegistro.Controls.Add(this.label7);
            this.mrcRegistro.Controls.Add(this.label6);
            this.mrcRegistro.Controls.Add(this.label5);
            this.mrcRegistro.Controls.Add(this.label4);
            this.mrcRegistro.Controls.Add(this.label3);
            this.mrcRegistro.Controls.Add(this.label2);
            this.mrcRegistro.Controls.Add(this.label1);
            this.mrcRegistro.Location = new System.Drawing.Point(12, 12);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(595, 171);
            this.mrcRegistro.TabIndex = 0;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro";
            // 
            // dtpApertura
            // 
            this.dtpApertura.Location = new System.Drawing.Point(92, 100);
            this.dtpApertura.Name = "dtpApertura";
            this.dtpApertura.Size = new System.Drawing.Size(200, 20);
            this.dtpApertura.TabIndex = 14;
            // 
            // cmbJuzgado
            // 
            this.cmbJuzgado.FormattingEnabled = true;
            this.cmbJuzgado.Location = new System.Drawing.Point(446, 27);
            this.cmbJuzgado.Name = "cmbJuzgado";
            this.cmbJuzgado.Size = new System.Drawing.Size(133, 21);
            this.cmbJuzgado.TabIndex = 13;
            // 
            // cmbLiquidador
            // 
            this.cmbLiquidador.FormattingEnabled = true;
            this.cmbLiquidador.Location = new System.Drawing.Point(446, 130);
            this.cmbLiquidador.Name = "cmbLiquidador";
            this.cmbLiquidador.Size = new System.Drawing.Size(133, 21);
            this.cmbLiquidador.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(446, 94);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(133, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(92, 65);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(132, 20);
            this.txtEntidad.TabIndex = 10;
            // 
            // txtNroExpediente
            // 
            this.txtNroExpediente.Location = new System.Drawing.Point(92, 135);
            this.txtNroExpediente.Name = "txtNroExpediente";
            this.txtNroExpediente.Size = new System.Drawing.Size(132, 20);
            this.txtNroExpediente.TabIndex = 8;
            // 
            // txtNroRegistro
            // 
            this.txtNroRegistro.Location = new System.Drawing.Point(92, 30);
            this.txtNroRegistro.Name = "txtNroRegistro";
            this.txtNroRegistro.Size = new System.Drawing.Size(49, 20);
            this.txtNroRegistro.TabIndex = 7;
            this.txtNroRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroRegistro_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Liquidador Responsable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Juzgado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nº Expe.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apertura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(626, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(626, 72);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(626, 107);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(626, 140);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvDatosRegistro
            // 
            this.dgvDatosRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosRegistro.Location = new System.Drawing.Point(12, 189);
            this.dgvDatosRegistro.Name = "dgvDatosRegistro";
            this.dgvDatosRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosRegistro.Size = new System.Drawing.Size(689, 199);
            this.dgvDatosRegistro.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Jurisdiccion";
            // 
            // cmbJurisdiccion
            // 
            this.cmbJurisdiccion.FormattingEnabled = true;
            this.cmbJurisdiccion.Location = new System.Drawing.Point(446, 62);
            this.cmbJurisdiccion.Name = "cmbJurisdiccion";
            this.cmbJurisdiccion.Size = new System.Drawing.Size(133, 21);
            this.cmbJurisdiccion.TabIndex = 17;
            // 
            // frmRegistroProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 399);
            this.Controls.Add(this.dgvDatosRegistro);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mrcRegistro);
            this.Name = "frmRegistroProvedores";
            this.Text = "Registro Provedores de Seguros";
            this.Load += new System.EventHandler(this.frmRegistroProvedores_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.DateTimePicker dtpApertura;
        private System.Windows.Forms.ComboBox cmbJuzgado;
        private System.Windows.Forms.ComboBox cmbLiquidador;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtNroExpediente;
        private System.Windows.Forms.TextBox txtNroRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvDatosRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbJurisdiccion;
    }
}