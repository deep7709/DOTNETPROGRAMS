namespace practical8
{
    partial class Form1
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
            this.lblfont = new System.Windows.Forms.Label();
            this.btninc = new System.Windows.Forms.Button();
            this.btndec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfont
            // 
            this.lblfont.AutoSize = true;
            this.lblfont.Location = new System.Drawing.Point(49, 110);
            this.lblfont.Name = "lblfont";
            this.lblfont.Size = new System.Drawing.Size(36, 13);
            this.lblfont.TabIndex = 0;
            this.lblfont.Text = "DEEP";
            // 
            // btninc
            // 
            this.btninc.Location = new System.Drawing.Point(36, 25);
            this.btninc.Name = "btninc";
            this.btninc.Size = new System.Drawing.Size(75, 23);
            this.btninc.TabIndex = 1;
            this.btninc.Text = "Increas";
            this.btninc.UseVisualStyleBackColor = true;
            this.btninc.Click += new System.EventHandler(this.btninc_Click);
            // 
            // btndec
            // 
            this.btndec.Location = new System.Drawing.Point(127, 25);
            this.btndec.Name = "btndec";
            this.btndec.Size = new System.Drawing.Size(75, 23);
            this.btndec.TabIndex = 1;
            this.btndec.Text = "Decreas";
            this.btndec.UseVisualStyleBackColor = true;
            this.btndec.Click += new System.EventHandler(this.btndec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btndec);
            this.Controls.Add(this.btninc);
            this.Controls.Add(this.lblfont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfont;
        private System.Windows.Forms.Button btninc;
        private System.Windows.Forms.Button btndec;
    }
}

