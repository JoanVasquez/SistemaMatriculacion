namespace com.SistemaMatriculacion.Vistas
{
    partial class VistaCarrera
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tablaCarreras = new System.Windows.Forms.DataGridView();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 12);
            this.txtNombre.MaxLength = 18;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombre.Location = new System.Drawing.Point(12, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // tablaCarreras
            // 
            this.tablaCarreras.AllowUserToAddRows = false;
            this.tablaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaId,
            this.columnaNombre});
            this.tablaCarreras.Location = new System.Drawing.Point(12, 69);
            this.tablaCarreras.Name = "tablaCarreras";
            this.tablaCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCarreras.Size = new System.Drawing.Size(361, 150);
            this.tablaCarreras.TabIndex = 3;
            this.tablaCarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCarreras_CellClick);
            // 
            // columnaId
            // 
            this.columnaId.DataPropertyName = "id";
            this.columnaId.HeaderText = "Id";
            this.columnaId.Name = "columnaId";
            this.columnaId.Width = 60;
            // 
            // columnaNombre
            // 
            this.columnaNombre.DataPropertyName = "nombre";
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.Width = 260;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(257, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // VistaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(385, 231);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tablaCarreras);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnUpdate);
            this.Name = "VistaCarrera";
            this.Text = "Carrera";
            this.Load += new System.EventHandler(this.VistaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView tablaCarreras;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.Button btnAgregar;
    }
}