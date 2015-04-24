namespace com.SistemaMatriculacion.Vistas
{
    partial class VistaMatriculacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminarAlumnosInterface; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.tablaAlumnos = new System.Windows.Forms.DataGridView();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCiclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCarreras = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.ayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivo
            // 
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGuardar,
            this.menuActualizar,
            this.menuEliminar,
            this.adminToolStripMenuItem,
            this.menuSalir});
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(60, 20);
            this.archivo.Text = "Archivo";
            // 
            // menuGuardar
            // 
            this.menuGuardar.Name = "menuGuardar";
            this.menuGuardar.Size = new System.Drawing.Size(126, 22);
            this.menuGuardar.Text = "Guardar";
            this.menuGuardar.Click += new System.EventHandler(this.menuGuardar_Click);
            // 
            // menuActualizar
            // 
            this.menuActualizar.Name = "menuActualizar";
            this.menuActualizar.Size = new System.Drawing.Size(126, 22);
            this.menuActualizar.Text = "Actualizar";
            this.menuActualizar.Click += new System.EventHandler(this.menuEditar_Click);
            // 
            // menuEliminar
            // 
            this.menuEliminar.Name = "menuEliminar";
            this.menuEliminar.Size = new System.Drawing.Size(126, 22);
            this.menuEliminar.Text = "Eliminar";
            this.menuEliminar.Click += new System.EventHandler(this.menuEliminar_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(126, 22);
            this.menuSalir.Text = "Salir";
            // 
            // ayuda
            // 
            this.ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcercaDe});
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(53, 20);
            this.ayuda.Text = "Ayuda";
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(126, 22);
            this.menuAcercaDe.Text = "Acerca de";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(4, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidos.Location = new System.Drawing.Point(4, 63);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(256, 37);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCarrera.Location = new System.Drawing.Point(256, 63);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDireccion.Location = new System.Drawing.Point(4, 89);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 34);
            this.txtNombre.MaxLength = 39;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(62, 60);
            this.txtApellidos.MaxLength = 39;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(188, 20);
            this.txtApellidos.TabIndex = 8;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtDateTime
            // 
            this.txtDateTime.CustomFormat = "yyyy-MM-dd";
            this.txtDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateTime.Location = new System.Drawing.Point(355, 34);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(88, 20);
            this.txtDateTime.TabIndex = 9;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCiclo.Location = new System.Drawing.Point(256, 90);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(30, 13);
            this.lblCiclo.TabIndex = 12;
            this.lblCiclo.Text = "Ciclo";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(355, 87);
            this.txtDia.MaxLength = 2;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(42, 20);
            this.txtDia.TabIndex = 13;
            this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_KeyPress);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(403, 87);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(40, 20);
            this.txtMes.TabIndex = 14;
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(449, 87);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(106, 20);
            this.txtAnio.TabIndex = 15;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            // 
            // tablaAlumnos
            // 
            this.tablaAlumnos.AllowUserToAddRows = false;
            this.tablaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaId,
            this.columnaNombre,
            this.columnaApellidos,
            this.columnaFechaNacimiento,
            this.columnaMatricula,
            this.columnaContraseña,
            this.columnaCiclo,
            this.columnaCarrera,
            this.columnaEstado,
            this.columnaPais,
            this.columnaDireccion});
            this.tablaAlumnos.Location = new System.Drawing.Point(12, 166);
            this.tablaAlumnos.MultiSelect = false;
            this.tablaAlumnos.Name = "tablaAlumnos";
            this.tablaAlumnos.ReadOnly = true;
            this.tablaAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAlumnos.Size = new System.Drawing.Size(556, 225);
            this.tablaAlumnos.TabIndex = 16;
            this.tablaAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaAlumnos_CellClick);
            // 
            // columnaId
            // 
            this.columnaId.HeaderText = "Id";
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.ReadOnly = true;
            // 
            // columnaApellidos
            // 
            this.columnaApellidos.HeaderText = "Apellidos";
            this.columnaApellidos.Name = "columnaApellidos";
            this.columnaApellidos.ReadOnly = true;
            // 
            // columnaFechaNacimiento
            // 
            this.columnaFechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.columnaFechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.columnaFechaNacimiento.Name = "columnaFechaNacimiento";
            this.columnaFechaNacimiento.ReadOnly = true;
            // 
            // columnaMatricula
            // 
            this.columnaMatricula.DataPropertyName = "matricula";
            this.columnaMatricula.HeaderText = "Matricula";
            this.columnaMatricula.Name = "columnaMatricula";
            this.columnaMatricula.ReadOnly = true;
            // 
            // columnaContraseña
            // 
            this.columnaContraseña.DataPropertyName = "contraseña";
            this.columnaContraseña.HeaderText = "Contraseña";
            this.columnaContraseña.Name = "columnaContraseña";
            this.columnaContraseña.ReadOnly = true;
            // 
            // columnaCiclo
            // 
            this.columnaCiclo.DataPropertyName = "ciclo";
            this.columnaCiclo.HeaderText = "Ciclo";
            this.columnaCiclo.Name = "columnaCiclo";
            this.columnaCiclo.ReadOnly = true;
            // 
            // columnaCarrera
            // 
            this.columnaCarrera.HeaderText = "Carrera";
            this.columnaCarrera.Name = "columnaCarrera";
            this.columnaCarrera.ReadOnly = true;
            // 
            // columnaEstado
            // 
            this.columnaEstado.HeaderText = "Estado";
            this.columnaEstado.Name = "columnaEstado";
            this.columnaEstado.ReadOnly = true;
            // 
            // columnaPais
            // 
            this.columnaPais.HeaderText = "Pais";
            this.columnaPais.Name = "columnaPais";
            this.columnaPais.ReadOnly = true;
            // 
            // columnaDireccion
            // 
            this.columnaDireccion.HeaderText = "Direccion";
            this.columnaDireccion.Name = "columnaDireccion";
            this.columnaDireccion.ReadOnly = true;
            // 
            // btnCarreras
            // 
            this.btnCarreras.Location = new System.Drawing.Point(526, 59);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(29, 23);
            this.btnCarreras.TabIndex = 18;
            this.btnCarreras.Text = "+";
            this.btnCarreras.UseVisualStyleBackColor = true;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(256, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(355, 113);
            this.txtPassword.MaxLength = 29;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(188, 20);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnDireccion
            // 
            this.btnDireccion.Location = new System.Drawing.Point(223, 86);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(27, 21);
            this.btnDireccion.TabIndex = 24;
            this.btnDireccion.Text = "+";
            this.btnDireccion.UseVisualStyleBackColor = true;
            this.btnDireccion.Click += new System.EventHandler(this.btnDireccion_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(62, 86);
            this.txtDireccion.MaxLength = 29;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(155, 20);
            this.txtDireccion.TabIndex = 25;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(355, 60);
            this.txtCarrera.MaxLength = 19;
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.ReadOnly = true;
            this.txtCarrera.Size = new System.Drawing.Size(165, 20);
            this.txtCarrera.TabIndex = 26;
            this.txtCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarrera_KeyPress);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstado.Location = new System.Drawing.Point(4, 113);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Text = "Estado";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPais.Location = new System.Drawing.Point(4, 140);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 28;
            this.lblPais.Text = "Pais";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(62, 113);
            this.txtEstado.MaxLength = 19;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(155, 20);
            this.txtEstado.TabIndex = 29;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(62, 140);
            this.txtPais.MaxLength = 19;
            this.txtPais.Name = "txtPais";
            this.txtPais.ReadOnly = true;
            this.txtPais.Size = new System.Drawing.Size(155, 20);
            this.txtPais.TabIndex = 30;
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPais_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(355, 137);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(449, 136);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 32;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // VistaMatriculacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(580, 403);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnDireccion);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnCarreras);
            this.Controls.Add(this.tablaAlumnos);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblCiclo);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VistaMatriculacion";
            this.Text = "Registrar Alumno";
            this.Load += new System.EventHandler(this.VistaMatriculacion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivo;
        private System.Windows.Forms.ToolStripMenuItem menuGuardar;
        private System.Windows.Forms.ToolStripMenuItem menuActualizar;
        private System.Windows.Forms.ToolStripMenuItem menuEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem ayuda;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.DateTimePicker txtDateTime;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.DataGridView tablaAlumnos;
        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaContraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCiclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDireccion;
        private System.Windows.Forms.Button btnReporte;
    }
}

