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
            this.sPLISTARALUMNOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrincipal1 = new ViolinSuzuki_Leila.DataSetPrincipal();
            this.sPLISTARALUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrincipal = new ViolinSuzuki_Leila.DataSetPrincipal();
            this.sP_LISTAR_ALUMNOSTableAdapter = new ViolinSuzuki_Leila.DataSetPrincipalTableAdapters.SP_LISTAR_ALUMNOSTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecnacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colegioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idalumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.fecnacDataGridViewTextBoxColumn,
            this.colegioDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgvAlumnos.DataSource = this.sPLISTARALUMNOSBindingSource1;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 110);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(847, 328);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // sPLISTARALUMNOSBindingSource1
            // 
            this.sPLISTARALUMNOSBindingSource1.DataMember = "SP_LISTAR_ALUMNOS";
            this.sPLISTARALUMNOSBindingSource1.DataSource = this.dataSetPrincipal1;
            // 
            // dataSetPrincipal1
            // 
            this.dataSetPrincipal1.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(879, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "Accion";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Text = "Seleccionar";
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
            // FormListadoDeAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(879, 458);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "FormListadoDeAlumnos";
            this.Text = "FormListadoDeAlumnos";
            this.Load += new System.EventHandler(this.FormListadoDeAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource sPLISTARALUMNOSBindingSource;
        private DataSetPrincipalTableAdapters.SP_LISTAR_ALUMNOSTableAdapter sP_LISTAR_ALUMNOSTableAdapter;
        private DataSetPrincipal dataSetPrincipal1;
        private System.Windows.Forms.BindingSource sPLISTARALUMNOSBindingSource1;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecnacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colegioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
    }
}