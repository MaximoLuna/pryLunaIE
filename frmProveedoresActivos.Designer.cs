﻿namespace pryLunaIE
{
    partial class frmProveedoresActivos
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbContenidoArchivo = new System.Windows.Forms.RichTextBox();
            this.tvCarpetas = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar archivo";
            // 
            // rtbContenidoArchivo
            // 
            this.rtbContenidoArchivo.Location = new System.Drawing.Point(272, 48);
            this.rtbContenidoArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.rtbContenidoArchivo.Name = "rtbContenidoArchivo";
            this.rtbContenidoArchivo.ReadOnly = true;
            this.rtbContenidoArchivo.Size = new System.Drawing.Size(276, 229);
            this.rtbContenidoArchivo.TabIndex = 4;
            this.rtbContenidoArchivo.Text = "";
            this.rtbContenidoArchivo.Visible = false;
            // 
            // tvCarpetas
            // 
            this.tvCarpetas.Location = new System.Drawing.Point(28, 48);
            this.tvCarpetas.Margin = new System.Windows.Forms.Padding(2);
            this.tvCarpetas.Name = "tvCarpetas";
            this.tvCarpetas.Size = new System.Drawing.Size(240, 229);
            this.tvCarpetas.TabIndex = 3;
            this.tvCarpetas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCarpetas_AfterSelect);
            // 
            // frmProveedoresActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbContenidoArchivo);
            this.Controls.Add(this.tvCarpetas);
            this.Name = "frmProveedoresActivos";
            this.Text = "Proveedores Activos";
            this.Load += new System.EventHandler(this.frmProveedoresActivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbContenidoArchivo;
        private System.Windows.Forms.TreeView tvCarpetas;
    }
}