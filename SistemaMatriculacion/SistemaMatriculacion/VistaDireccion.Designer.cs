namespace com.SistemaMatriculacion.Vistas
{
    partial class VistaDireccion
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.RichTextBox();
            this.tablaDireccion = new System.Windows.Forms.DataGridView();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstado.Location = new System.Drawing.Point(12, 7);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 16);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPais.Location = new System.Drawing.Point(12, 33);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 16);
            this.lblPais.TabIndex = 1;
            this.lblPais.Text = "Pais";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(12, 55);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 16);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(75, 6);
            this.txtEstado.MaxLength = 19;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(159, 20);
            this.txtEstado.TabIndex = 3;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(75, 32);
            this.txtPais.MaxLength = 19;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(159, 20);
            this.txtPais.TabIndex = 4;
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPais_KeyPress);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(240, 70);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(240, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(240, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(240, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(12, 74);
            this.txtDireccion.MaxLength = 28;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(219, 77);
            this.txtDireccion.TabIndex = 9;
            this.txtDireccion.Text = "";
            // 
            // tablaDireccion
            // 
            this.tablaDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDireccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaId,
            this.columnaDireccion,
            this.columnaPais,
            this.columnaEstado});
            this.tablaDireccion.Location = new System.Drawing.Point(12, 158);
            this.tablaDireccion.MultiSelect = false;
            this.tablaDireccion.Name = "tablaDireccion";
            this.tablaDireccion.ReadOnly = true;
            this.tablaDireccion.Size = new System.Drawing.Size(303, 176);
            this.tablaDireccion.TabIndex = 10;
            this.tablaDireccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDireccion_CellClick);
            // 
            // columnaId
            // 
            this.columnaId.DataPropertyName = "id";
            this.columnaId.HeaderText = "Id";
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            this.columnaId.Width = 60;
            // 
            // columnaDireccion
            // 
            this.columnaDireccion.DataPropertyName = "direccion";
            this.columnaDireccion.HeaderText = "Direccion";
            this.columnaDireccion.Name = "columnaDireccion";
            this.columnaDireccion.ReadOnly = true;
            this.columnaDireccion.Width = 160;
            // 
            // columnaPais
            // 
            this.columnaPais.DataPropertyName = "pais";
            this.columnaPais.HeaderText = "Pais";
            this.columnaPais.Name = "columnaPais";
            this.columnaPais.ReadOnly = true;
            this.columnaPais.Width = 130;
            // 
            // columnaEstado
            // 
            this.columnaEstado.DataPropertyName = "estado";
            this.columnaEstado.HeaderText = "Estado";
            this.columnaEstado.Name = "columnaEstado";
            this.columnaEstado.ReadOnly = true;
            this.columnaEstado.Width = 130;
            // 
            // VistaDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(327, 346);
            this.Controls.Add(this.tablaDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Name = "VistaDireccion";
            this.Text = "Direccion";
            this.Load += new System.EventHandler(this.VistaDireccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox txtDireccion;
        private System.Windows.Forms.DataGridView tablaDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEstado;
    }
}