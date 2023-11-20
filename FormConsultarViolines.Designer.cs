namespace ViolinSuzuki_Leila
{
    partial class FormConsultarViolines
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetPrincipal = new ViolinSuzuki_Leila.DataSetPrincipal();
            this.sPCONSULTARVIOLINESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CONSULTAR_VIOLINESTableAdapter = new ViolinSuzuki_Leila.DataSetPrincipalTableAdapters.SP_CONSULTAR_VIOLINESTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERTENECEADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARVIOLINESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Violines";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.mEDIDADataGridViewTextBoxColumn,
            this.mARCADataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.pERTENECEADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPCONSULTARVIOLINESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 354);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPCONSULTARVIOLINESBindingSource
            // 
            this.sPCONSULTARVIOLINESBindingSource.DataMember = "SP_CONSULTAR_VIOLINES";
            this.sPCONSULTARVIOLINESBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // sP_CONSULTAR_VIOLINESTableAdapter
            // 
            this.sP_CONSULTAR_VIOLINESTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // mEDIDADataGridViewTextBoxColumn
            // 
            this.mEDIDADataGridViewTextBoxColumn.DataPropertyName = "MEDIDA";
            this.mEDIDADataGridViewTextBoxColumn.HeaderText = "MEDIDA";
            this.mEDIDADataGridViewTextBoxColumn.Name = "mEDIDADataGridViewTextBoxColumn";
            // 
            // mARCADataGridViewTextBoxColumn
            // 
            this.mARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA";
            this.mARCADataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.mARCADataGridViewTextBoxColumn.Name = "mARCADataGridViewTextBoxColumn";
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            // 
            // pERTENECEADataGridViewTextBoxColumn
            // 
            this.pERTENECEADataGridViewTextBoxColumn.DataPropertyName = "PERTENECE A:";
            this.pERTENECEADataGridViewTextBoxColumn.HeaderText = "PERTENECE A:";
            this.pERTENECEADataGridViewTextBoxColumn.Name = "pERTENECEADataGridViewTextBoxColumn";
            this.pERTENECEADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormConsultarViolines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "FormConsultarViolines";
            this.Text = "FormConsultarViolines";
            this.Load += new System.EventHandler(this.FormConsultarViolines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARVIOLINESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource sPCONSULTARVIOLINESBindingSource;
        private DataSetPrincipalTableAdapters.SP_CONSULTAR_VIOLINESTableAdapter sP_CONSULTAR_VIOLINESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERTENECEADataGridViewTextBoxColumn;
    }
}