namespace ViolinSuzuki_Leila.Reportes
{
    partial class FormReporteClase
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetReportes = new ViolinSuzuki_Leila.Reportes.DataSetReportes();
            this.sPREPORTEPROGRESOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_REPORTE_PROGRESOTableAdapter = new ViolinSuzuki_Leila.Reportes.DataSetReportesTableAdapters.SP_REPORTE_PROGRESOTableAdapter();
            this.SP_REPORTE_PROGRESOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPREPORTEPROGRESOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTEPROGRESOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_PROGRESOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTEPROGRESOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatasetAlumno";
            reportDataSource1.Value = this.SP_REPORTE_PROGRESOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ViolinSuzuki_Leila.Reportes.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPREPORTEPROGRESOBindingSource
            // 
            this.sPREPORTEPROGRESOBindingSource.DataMember = "SP_REPORTE_PROGRESO";
            this.sPREPORTEPROGRESOBindingSource.DataSource = this.dataSetReportes;
            // 
            // sP_REPORTE_PROGRESOTableAdapter
            // 
            this.sP_REPORTE_PROGRESOTableAdapter.ClearBeforeFill = true;
            // 
            // SP_REPORTE_PROGRESOBindingSource
            // 
            this.SP_REPORTE_PROGRESOBindingSource.DataMember = "SP_REPORTE_PROGRESO";
            this.SP_REPORTE_PROGRESOBindingSource.DataSource = this.dataSetReportes;
            // 
            // sPREPORTEPROGRESOBindingSource1
            // 
            this.sPREPORTEPROGRESOBindingSource1.DataMember = "SP_REPORTE_PROGRESO";
            this.sPREPORTEPROGRESOBindingSource1.DataSource = this.dataSetReportes;
            // 
            // FormReporteClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteClase";
            this.Text = "FormReporteClase";
            this.Load += new System.EventHandler(this.FormReporteClase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTEPROGRESOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_PROGRESOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTEPROGRESOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPREPORTEPROGRESOBindingSource;
        private DataSetReportes dataSetReportes;
        private DataSetReportesTableAdapters.SP_REPORTE_PROGRESOTableAdapter sP_REPORTE_PROGRESOTableAdapter;
        private System.Windows.Forms.BindingSource SP_REPORTE_PROGRESOBindingSource;
        private System.Windows.Forms.BindingSource sPREPORTEPROGRESOBindingSource1;
    }
}