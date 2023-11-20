namespace ViolinSuzuki_Leila.Calendario
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDay = new System.Windows.Forms.Label();
            this.btnEvento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(3, 10);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(34, 25);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "00";
            // 
            // btnEvento
            // 
            this.btnEvento.BackColor = System.Drawing.Color.Transparent;
            this.btnEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEvento.Location = new System.Drawing.Point(8, 71);
            this.btnEvento.Name = "btnEvento";
            this.btnEvento.Size = new System.Drawing.Size(162, 23);
            this.btnEvento.TabIndex = 2;
            this.btnEvento.UseVisualStyleBackColor = false;
            this.btnEvento.Click += new System.EventHandler(this.btnEvento_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnEvento);
            this.Controls.Add(this.lblDay);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(173, 108);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnEvento;
    }
}
