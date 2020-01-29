namespace maashesaplama
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
            this.lblNetMaas = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtNetMaas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNetMaas
            // 
            this.lblNetMaas.AutoSize = true;
            this.lblNetMaas.Location = new System.Drawing.Point(30, 50);
            this.lblNetMaas.Name = "lblNetMaas";
            this.lblNetMaas.Size = new System.Drawing.Size(56, 13);
            this.lblNetMaas.TabIndex = 0;
            this.lblNetMaas.Text = "Net Maaş:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(101, 82);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtNetMaas
            // 
            this.txtNetMaas.Location = new System.Drawing.Point(92, 47);
            this.txtNetMaas.Name = "txtNetMaas";
            this.txtNetMaas.Size = new System.Drawing.Size(100, 20);
            this.txtNetMaas.TabIndex = 2;
            this.txtNetMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetMaas_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 309);
            this.Controls.Add(this.txtNetMaas);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblNetMaas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNetMaas;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtNetMaas;
    }
}

