namespace TugasCalculatorWindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai A";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(87, 77);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(189, 20);
            this.txtNilaiA.TabIndex = 1;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(87, 103);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(189, 20);
            this.txtNilaiB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nilai B";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(201, 155);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 4;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasil";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(87, 129);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(189, 20);
            this.txtHasil.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operasi";
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmbOperasi.Location = new System.Drawing.Point(87, 20);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(189, 21);
            this.cmbOperasi.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 207);
            this.Controls.Add(this.cmbOperasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOperasi;
    }
}

