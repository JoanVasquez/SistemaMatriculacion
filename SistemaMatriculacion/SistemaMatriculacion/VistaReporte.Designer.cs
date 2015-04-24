namespace com.SistemaMatriculacion.Vistas
{
    partial class VistaReporte
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
            this.reporteView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Informe1 = new com.SistemaMatriculacion.Vistas.Informe();
            this.SuspendLayout();
            // 
            // reporteView
            // 
            this.reporteView.ActiveViewIndex = 0;
            this.reporteView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporteView.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteView.Location = new System.Drawing.Point(12, 12);
            this.reporteView.Name = "reporteView";
            this.reporteView.ReportSource = this.Informe1;
            this.reporteView.Size = new System.Drawing.Size(866, 485);
            this.reporteView.TabIndex = 1;
            this.reporteView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VistaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(890, 509);
            this.Controls.Add(this.reporteView);
            this.Name = "VistaReporte";
            this.Text = "VistaReporte";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporteView;
        private Informe Informe1;
    }
}