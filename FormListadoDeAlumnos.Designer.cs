namespace ViolinSuzuki_Leila
{
    partial class FormListadoDeAlumnos
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecnacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colegioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPLISTARALUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrincipal = new ViolinSuzuki_Leila.DataSetPrincipal();
            this.sP_LISTAR_ALUMNOSTableAdapter = new ViolinSuzuki_Leila.DataSetPrincipalTableAdapters.SP_LISTAR_ALUMNOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.calleDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.idciudadDataGridViewTextBoxColumn,
            this.fecaltaDataGridViewTextBoxColumn,
            this.fecnacDataGridViewTextBoxColumn,
            this.colegioDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgvAlumnos.DataSource = this.sPLISTARALUMNOSBindingSource;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 110);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(847, 328);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // idalumnoDataGridViewTextBoxColumn
            // 
            this.idalumnoDataGridViewTextBoxColumn.DataPropertyName = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.HeaderText = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.Name = "idalumnoDataGridViewTextBoxColumn";
            this.idalumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // calleDataGridViewTextBoxColumn
            // 
            this.calleDataGridViewTextBoxColumn.DataPropertyName = "calle";
            this.calleDataGridViewTextBoxColumn.HeaderText = "calle";
            this.calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            // 
            // idciudadDataGridViewTextBoxColumn
            // 
            this.idciudadDataGridViewTextBoxColumn.DataPropertyName = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.HeaderText = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.Name = "idciudadDataGridViewTextBoxColumn";
            // 
            // fecaltaDataGridViewTextBoxColumn
            // 
            this.fecaltaDataGridViewTextBoxColumn.DataPropertyName = "fec_alta";
            this.fecaltaDataGridViewTextBoxColumn.HeaderText = "fec_alta";
            this.fecaltaDataGridViewTextBoxColumn.Name = "fecaltaDataGridViewTextBoxColumn";
            // 
            // fecnacDataGridViewTextBoxColumn
            // 
            this.fecnacDataGridViewTextBoxColumn.DataPropertyName = "fec_nac";
            this.fecnacDataGridViewTextBoxColumn.HeaderText = "fec_nac";
            this.fecnacDataGridViewTextBoxColumn.Name = "fecnacDataGridViewTextBoxColumn";
            // 
            // colegioDataGridViewTextBoxColumn
            // 
            this.colegioDataGridViewTextBoxColumn.DataPropertyName = "colegio";
            this.colegioDataGridViewTextBoxColumn.HeaderText = "colegio";
            this.colegioDataGridViewTextBoxColumn.Name = "colegioDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // sPLISTARALUMNOSBindingSource
            // 
            this.sPLISTARALUMNOSBindingSource.DataMember = "SP_LISTAR_ALUMNOS";
            this.sPLISTARALUMNOSBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LISTAR_ALUMNOSTableAdapter
            // 
            this.sP_LISTAR_ALUMNOSTableAdapter.ClearBeforeFill = true;
            // 
            // FormListadoDeAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "FormListadoDeAlumnos";
            this.Text = "FormListadoDeAlumnos";
            this.Load += new System.EventHandler(this.FormListadoDeAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource sPLISTARALUMNOSBindingSource;
        private DataSetPrincipalTableAdapters.SP_LISTAR_ALUMNOSTableAdapter sP_LISTAR_ALUMNOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecnacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colegioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
    }
}