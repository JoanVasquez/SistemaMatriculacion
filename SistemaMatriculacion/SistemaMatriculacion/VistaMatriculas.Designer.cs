namespace com.SistemaMatriculacion.Vistas
{
    partial class VistaMatriculas
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
            this.lblCiclo = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtSecuencia = new System.Windows.Forms.TextBox();
            this.btnGenera = new System.Windows.Forms.Button();
            this.tablaMatriculas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(13, 13);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(30, 13);
            this.lblCiclo.TabIndex = 0;
            this.lblCiclo.Text = "Ciclo";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(265, 46);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(55, 13);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matriculas";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(49, 10);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(39, 20);
            this.txtDia.TabIndex = 2;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(94, 10);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(66, 20);
            this.txtMes.TabIndex = 3;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(166, 10);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 4;
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Enabled = false;
            this.txtSecuencia.Location = new System.Drawing.Point(272, 10);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Size = new System.Drawing.Size(49, 20);
            this.txtSecuencia.TabIndex = 5;
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(49, 36);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(75, 23);
            this.btnGenera.TabIndex = 7;
            this.btnGenera.Text = "Generar";
            this.btnGenera.UseVisualStyleBackColor = true;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // tablaMatriculas
            // 
            this.tablaMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMatriculas.Location = new System.Drawing.Point(12, 65);
            this.tablaMatriculas.Name = "tablaMatriculas";
            this.tablaMatriculas.Size = new System.Drawing.Size(308, 91);
            this.tablaMatriculas.TabIndex = 8;
            this.tablaMatriculas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tablaMatriculas_MouseClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(131, 35);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // VistaMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 168);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tablaMatriculas);
            this.Controls.Add(this.btnGenera);
            this.Controls.Add(this.txtSecuencia);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblCiclo);
            this.Name = "VistaMatriculas";
            this.Text = "VistaMatriculas";
            this.Load += new System.EventHandler(this.VistaMatriculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtSecuencia;
        private System.Windows.Forms.Button btnGenera;
        private System.Windows.Forms.DataGridView tablaMatriculas;
        private System.Windows.Forms.Button btnEliminar;
    }
}