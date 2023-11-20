namespace ViolinSuzuki_Leila
{
    partial class FormConsultarClases
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConsultarClases = new System.Windows.Forms.DataGridView();
            this.dataSetPrincipal = new ViolinSuzuki_Leila.DataSetPrincipal();
            this.sPCONSULTARPROGRESOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CONSULTAR_PROGRESOSTableAdapter = new ViolinSuzuki_Leila.DataSetPrincipalTableAdapters.SP_CONSULTAR_PROGRESOSTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLUMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESPONSABLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARPROGRESOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clases";
            // 
            // dgvConsultarClases
            // 
            this.dgvConsultarClases.AutoGenerateColumns = false;
            this.dgvConsultarClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.aLUMNODataGridViewTextBoxColumn,
            this.rESPONSABLEDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.btnVerDetalles});
            this.dgvConsultarClases.DataSource = this.sPCONSULTARPROGRESOSBindingSource;
            this.dgvConsultarClases.Location = new System.Drawing.Point(12, 77);
            this.dgvConsultarClases.Name = "dgvConsultarClases";
            this.dgvConsultarClases.Size = new System.Drawing.Size(776, 361);
            this.dgvConsultarClases.TabIndex = 9;
            this.dgvConsultarClases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarClases_CellContentClick);
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPCONSULTARPROGRESOSBindingSource
            // 
            this.sPCONSULTARPROGRESOSBindingSource.DataMember = "SP_CONSULTAR_PROGRESOS";
            this.sPCONSULTARPROGRESOSBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // sP_CONSULTAR_PROGRESOSTableAdapter
            // 
            this.sP_CONSULTAR_PROGRESOSTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // aLUMNODataGridViewTextBoxColumn
            // 
            this.aLUMNODataGridViewTextBoxColumn.DataPropertyName = "ALUMNO";
            this.aLUMNODataGridViewTextBoxColumn.HeaderText = "ALUMNO";
            this.aLUMNODataGridViewTextBoxColumn.Name = "aLUMNODataGridViewTextBoxColumn";
            this.aLUMNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rESPONSABLEDataGridViewTextBoxColumn
            // 
            this.rESPONSABLEDataGridViewTextBoxColumn.DataPropertyName = "RESPONSABLE";
            this.rESPONSABLEDataGridViewTextBoxColumn.HeaderText = "RESPONSABLE";
            this.rESPONSABLEDataGridViewTextBoxColumn.Name = "rESPONSABLEDataGridViewTextBoxColumn";
            this.rESPONSABLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.HeaderText = "VER DETALLES";
            this.btnVerDetalles.Name = "btnVerDetalles";
            // 
            // FormConsultarClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvConsultarClases);
            this.Controls.Add(this.label2);
            this.Name = "FormConsultarClases";
            this.Text = "FormConsultaClases";
            this.Load += new System.EventHandler(this.FormConsultarClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARPROGRESOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConsultarClases;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource sPCONSULTARPROGRESOSBindingSource;
        private DataSetPrincipalTableAdapters.SP_CONSULTAR_PROGRESOSTableAdapter sP_CONSULTAR_PROGRESOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLUMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESPONSABLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnVerDetalles;
    }
}