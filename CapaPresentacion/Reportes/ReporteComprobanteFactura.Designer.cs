namespace CapaPresentacion
{
    partial class ReporteComprobanteFactura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spreporte_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TodosReportes = new CapaPresentacion.TodosReportes();
            this.spreporte_facturaTableAdapter = new CapaPresentacion.TodosReportesTableAdapters.spreporte_facturaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // spreporte_facturaBindingSource
            // 
            this.spreporte_facturaBindingSource.DataMember = "spreporte_factura";
            this.spreporte_facturaBindingSource.DataSource = this.TodosReportes;
            // 
            // TodosReportes
            // 
            this.TodosReportes.DataSetName = "TodosReportes";
            this.TodosReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporte_facturaTableAdapter
            // 
            this.spreporte_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spreporte_facturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptComprobanteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(567, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteComprobanteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 379);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteComprobanteFactura";
            this.Text = "ReporteComprobanteFactura";
            this.Load += new System.EventHandler(this.ReporteComprobanteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource spreporte_facturaBindingSource;
        private TodosReportes TodosReportes;
        private TodosReportesTableAdapters.spreporte_facturaTableAdapter spreporte_facturaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}