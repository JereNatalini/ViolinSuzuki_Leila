namespace ViolinSuzuki_Leila
{
    partial class FormTiposDeCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiposDeCarga));
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnViolines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersona.BackgroundImage")));
            this.btnPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersona.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersona.ForeColor = System.Drawing.Color.White;
            this.btnPersona.Location = new System.Drawing.Point(116, 148);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(187, 155);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Personas";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnViolines
            // 
            this.btnViolines.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViolines.BackgroundImage")));
            this.btnViolines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViolines.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViolines.ForeColor = System.Drawing.Color.White;
            this.btnViolines.Location = new System.Drawing.Point(476, 148);
            this.btnViolines.Name = "btnViolines";
            this.btnViolines.Size = new System.Drawing.Size(163, 155);
            this.btnViolines.TabIndex = 1;
            this.btnViolines.Text = "Violines";
            this.btnViolines.UseVisualStyleBackColor = true;
            this.btnViolines.Click += new System.EventHandler(this.btnViolines_Click);
            // 
            // FormTiposDeCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(52)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.btnViolines);
            this.Controls.Add(this.btnPersona);
            this.Name = "FormTiposDeCarga";
            this.Text = "FormTiposDeCarga";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnViolines;
    }
}