namespace ViolinSuzuki_Leila
{
    partial class FormListarResponsablesPagos
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
            this.dgvResponsables = new System.Windows.Forms.DataGridView();
            this.btnSinResponsable = new System.Windows.Forms.Button();
            this.dataSetPrincipal = new ViolinSuzuki_Leila.DataSetPrincipal();
            this.sPLISTARRESPONSABLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LISTAR_RESPONSABLESTableAdapter = new ViolinSuzuki_Leila.DataSetPrincipalTableAdapters.SP_LISTAR_RESPONSABLESTableAdapter();
            this.idresponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiporesponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtiporesponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARRESPONSABLESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el responsable.";
            // 
            // dgvResponsables
            // 
            this.dgvResponsables.AutoGenerateColumns = false;
            this.dgvResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idresponsableDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.tiporesponsableDataGridViewTextBoxColumn,
            this.idtiporesponsableDataGridViewTextBoxColumn,
            this.btnSeleccionar});
            this.dgvResponsables.DataSource = this.sPLISTARRESPONSABLESBindingSource;
            this.dgvResponsables.Location = new System.Drawing.Point(12, 139);
            this.dgvResponsables.Name = "dgvResponsables";
            this.dgvResponsables.Size = new System.Drawing.Size(776, 299);
            this.dgvResponsables.TabIndex = 3;
            this.dgvResponsables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsables_CellContentClick);
            // 
            // btnSinResponsable
            // 
            this.btnSinResponsable.Location = new System.Drawing.Point(664, 90);
            this.btnSinResponsable.Name = "btnSinResponsable";
            this.btnSinResponsable.Size = new System.Drawing.Size(124, 43);
            this.btnSinResponsable.TabIndex = 4;
            this.btnSinResponsable.Text = "Sin Responsable";
            this.btnSinResponsable.UseVisualStyleBackColor = true;
            this.btnSinResponsable.Click += new System.EventHandler(this.btnSinResponsable_Click);
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPLISTARRESPONSABLESBindingSource
            // 
            this.sPLISTARRESPONSABLESBindingSource.DataMember = "SP_LISTAR_RESPONSABLES";
            this.sPLISTARRESPONSABLESBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // sP_LISTAR_RESPONSABLESTableAdapter
            // 
            this.sP_LISTAR_RESPONSABLESTableAdapter.ClearBeforeFill = true;
            // 
            // idresponsableDataGridViewTextBoxColumn
            // 
            this.idresponsableDataGridViewTextBoxColumn.DataPropertyName = "id_responsable";
            this.idresponsableDataGridViewTextBoxColumn.HeaderText = "id_responsable";
            this.idresponsableDataGridViewTextBoxColumn.Name = "idresponsableDataGridViewTextBoxColumn";
            this.idresponsableDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tiporesponsableDataGridViewTextBoxColumn
            // 
            this.tiporesponsableDataGridViewTextBoxColumn.DataPropertyName = "tipo_responsable";
            this.tiporesponsableDataGridViewTextBoxColumn.HeaderText = "tipo_responsable";
            this.tiporesponsableDataGridViewTextBoxColumn.Name = "tiporesponsableDataGridViewTextBoxColumn";
            // 
            // idtiporesponsableDataGridViewTextBoxColumn
            // 
            this.idtiporesponsableDataGridViewTextBoxColumn.DataPropertyName = "id_tipo_responsable";
            this.idtiporesponsableDataGridViewTextBoxColumn.HeaderText = "id_tipo_responsable";
            this.idtiporesponsableDataGridViewTextBoxColumn.Name = "idtiporesponsableDataGridViewTextBoxColumn";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.Name = "btnSeleccionar";
            // 
            // FormListarResponsablesPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSinResponsable);
            this.Controls.Add(this.dgvResponsables);
            this.Controls.Add(this.label1);
            this.Name = "FormListarResponsablesPagos";
            this.Text = "FormListarResponsablesPagos";
            this.Load += new System.EventHandler(this.FormListarResponsablesPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARRESPONSABLESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResponsables;
        private System.Windows.Forms.Button btnSinResponsable;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource sPLISTARRESPONSABLESBindingSource;
        private DataSetPrincipalTableAdapters.SP_LISTAR_RESPONSABLESTableAdapter sP_LISTAR_RESPONSABLESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idresponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiporesponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtiporesponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
    }
}