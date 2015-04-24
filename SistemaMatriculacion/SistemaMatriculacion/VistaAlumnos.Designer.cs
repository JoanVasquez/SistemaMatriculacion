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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.menuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.tablaMatriculacion = new System.Windows.Forms.DataGridView();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.cbCarreras = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMatriculacion)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.ayuda,
            this.Admin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivo
            // 
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevo,
            this.menuEditar,
            this.menuEliminar,
            this.menuSalir});
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(60, 20);
            this.archivo.Text = "Archivo";
            // 
            // menuNuevo
            // 
            this.menuNuevo.Name = "menuNuevo";
            this.menuNuevo.Size = new System.Drawing.Size(117, 22);
            this.menuNuevo.Text = "Nuevo";
            this.menuNuevo.Click += new System.EventHandler(this.menuNuevo_Click);
            // 
            // menuEditar
            // 
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(117, 22);
            this.menuEditar.Text = "Editar";
            // 
            // menuEliminar
            // 
            this.menuEliminar.Name = "menuEliminar";
            this.menuEliminar.Size = new System.Drawing.Size(117, 22);
            this.menuEliminar.Text = "Eliminar";
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(117, 22);
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
            // Admin
            // 
            this.Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgregar});
            this.Admin.Enabled = false;
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(55, 20);
            this.Admin.Text = "Admin";
            // 
            // menuAgregar
            // 
            this.menuAgregar.Enabled = false;
            this.menuAgregar.Name = "menuAgregar";
            this.menuAgregar.Size = new System.Drawing.Size(116, 22);
            this.menuAgregar.Text = "Agregar";
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
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(62, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(62, 60);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(188, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtDateTime
            // 
            this.txtDateTime.CustomFormat = "yyyy-MM-dd";
            this.txtDateTime.Enabled = false;
            this.txtDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateTime.Location = new System.Drawing.Point(355, 34);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(88, 20);
            this.txtDateTime.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(62, 86);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(188, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // tablaMatriculacion
            // 
            this.tablaMatriculacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMatriculacion.Location = new System.Drawing.Point(12, 164);
            this.tablaMatriculacion.Name = "tablaMatriculacion";
            this.tablaMatriculacion.Size = new System.Drawing.Size(556, 202);
            this.tablaMatriculacion.TabIndex = 16;
            this.tablaMatriculacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.tablaMatriculacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSexo.Location = new System.Drawing.Point(256, 141);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 19;
            this.lblSexo.Text = "Sexo";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(256, 118);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(355, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 20);
            this.txtPassword.TabIndex = 23;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPais.Location = new System.Drawing.Point(4, 115);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 24;
            this.lblPais.Text = "Pais";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstado.Location = new System.Drawing.Point(4, 141);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado";
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(62, 112);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(188, 20);
            this.txtPais.TabIndex = 26;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(62, 138);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(188, 20);
            this.txtEstado.TabIndex = 27;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 373);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(94, 372);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(175, 372);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Enabled = false;
            this.radioMasculino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioMasculino.Location = new System.Drawing.Point(355, 141);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(34, 17);
            this.radioMasculino.TabIndex = 20;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "M";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Enabled = false;
            this.radioFemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioFemale.Location = new System.Drawing.Point(395, 141);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(31, 17);
            this.radioFemale.TabIndex = 21;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "F";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // cbCarreras
            // 
            this.cbCarreras.FormattingEnabled = true;
            this.cbCarreras.Location = new System.Drawing.Point(355, 63);
            this.cbCarreras.Name = "cbCarreras";
            this.cbCarreras.Size = new System.Drawing.Size(194, 21);
            this.cbCarreras.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(256, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Carrera";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(355, 89);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(194, 20);
            this.txtCarrera.TabIndex = 36;
            // 
            // VistaMatriculacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(580, 403);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbCarreras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMasculino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.tablaMatriculacion);
            this.Controls.Add(this.txtDireccion);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMatriculacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivo;
        private System.Windows.Forms.ToolStripMenuItem menuNuevo;
        private System.Windows.Forms.ToolStripMenuItem menuEditar;
        private System.Windows.Forms.ToolStripMenuItem menuEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem ayuda;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem Admin;
        private System.Windows.Forms.ToolStripMenuItem menuAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.DateTimePicker txtDateTime;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView tablaMatriculacion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.ComboBox cbCarreras;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarrera;
    }
}

