namespace com.SistemaMatriculacion.Vistas
{
    partial class VistaRegistrarse
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(12, 13);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(134, 13);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(134, 43);
            this.txtPass.MaxLength = 25;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(210, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPass.Location = new System.Drawing.Point(12, 39);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(116, 24);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Contrasena";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 78);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(93, 78);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 78);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AllowUserToAddRows = false;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaId,
            this.columnaEmail,
            this.columnaPass});
            this.tablaUsuarios.Location = new System.Drawing.Point(13, 107);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.Size = new System.Drawing.Size(331, 150);
            this.tablaUsuarios.TabIndex = 3;
            this.tablaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellClick);
            // 
            // columnaId
            // 
            this.columnaId.DataPropertyName = "id";
            this.columnaId.HeaderText = "Id";
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            // 
            // columnaEmail
            // 
            this.columnaEmail.DataPropertyName = "email";
            this.columnaEmail.HeaderText = "Email";
            this.columnaEmail.Name = "columnaEmail";
            this.columnaEmail.ReadOnly = true;
            this.columnaEmail.Width = 200;
            // 
            // columnaPass
            // 
            this.columnaPass.DataPropertyName = "pass";
            this.columnaPass.HeaderText = "Contrasena";
            this.columnaPass.Name = "columnaPass";
            this.columnaPass.ReadOnly = true;
            this.columnaPass.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(256, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VistaRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "VistaRegistrarse";
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.VistaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPass;
        private System.Windows.Forms.Button btnSalir;
    }
}