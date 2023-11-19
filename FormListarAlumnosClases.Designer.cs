namespace ViolinSuzuki_Leila
{
    partial class FormListarAlumnosClases
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.dataSetPrincipal = new ViolinSuzuki_Leila.DataSetPrincipal();
            this.sP_LISTAR_ALUMNOSTableAdapter = new ViolinSuzuki_Leila.DataSetPrincipalTableAdapters.SP_LISTAR_ALUMNOSTableAdapter();
            this.sP_LISTAR_RESPONSABLESTableAdapter = new ViolinSuzuki_Leila.DataSetPrincipalTableAdapters.SP_LISTAR_RESPONSABLESTableAdapter();
            this.dataSetPrincipal1 = new ViolinSuzuki_Leila.DataSetPrincipal();
            this.sPLISTARALUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el alummo que tomara la clase";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AutoGenerateColumns = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.btnSeleccionar});
            this.dgvAlumnos.DataSource = this.sPLISTARALUMNOSBindingSource;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 136);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(776, 302);
            this.dgvAlumnos.TabIndex = 1;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // sP_LISTAR_RESPONSABLESTableAdapter
            // 
            this.sP_LISTAR_RESPONSABLESTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetPrincipal1
            // 
            this.dataSetPrincipal1.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPLISTARALUMNOSBindingSource
            // 
            this.sPLISTARALUMNOSBindingSource.DataMember = "SP_LISTAR_ALUMNOS";
            this.sPLISTARALUMNOSBindingSource.DataSource = this.dataSetPrincipal1;
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
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.Name = "btnSeleccionar";
            // 
            // FormListarAlumnosClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.label1);
            this.Name = "FormListarAlumnosClases";
            this.Text = "FormListarAlumnosClases";
            this.Load += new System.EventHandler(this.FormListarAlumnosClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARALUMNOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private DataSetPrincipal dataSetPrincipal;
        private DataSetPrincipalTableAdapters.SP_LISTAR_ALUMNOSTableAdapter sP_LISTAR_ALUMNOSTableAdapter;
        private DataSetPrincipalTableAdapters.SP_LISTAR_RESPONSABLESTableAdapter sP_LISTAR_RESPONSABLESTableAdapter;
        private DataSetPrincipal dataSetPrincipal1;
        private System.Windows.Forms.BindingSource sPLISTARALUMNOSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
    }
}