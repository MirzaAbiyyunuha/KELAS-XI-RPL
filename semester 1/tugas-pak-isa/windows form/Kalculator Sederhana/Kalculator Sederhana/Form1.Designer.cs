namespace Kalculator_Sederhana
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
            this.textAngka1 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.textAngka2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teksAngka1 = new System.Windows.Forms.TextBox();
            this.teksAngka2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAngka1
            // 
            this.textAngka1.AutoSize = true;
            this.textAngka1.Location = new System.Drawing.Point(27, 86);
            this.textAngka1.Name = "textAngka1";
            this.textAngka1.Size = new System.Drawing.Size(44, 13);
            this.textAngka1.TabIndex = 0;
            this.textAngka1.Text = "Angka1";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(30, 212);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(297, 23);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(27, 164);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(33, 13);
            this.lblHasil.TabIndex = 0;
            this.lblHasil.Text = "Hasil:";
            // 
            // textAngka2
            // 
            this.textAngka2.AutoSize = true;
            this.textAngka2.Location = new System.Drawing.Point(27, 125);
            this.textAngka2.Name = "textAngka2";
            this.textAngka2.Size = new System.Drawing.Size(44, 13);
            this.textAngka2.TabIndex = 0;
            this.textAngka2.Text = "Angka2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aksi";
            // 
            // teksAngka1
            // 
            this.teksAngka1.Location = new System.Drawing.Point(30, 102);
            this.teksAngka1.Name = "teksAngka1";
            this.teksAngka1.Size = new System.Drawing.Size(297, 20);
            this.teksAngka1.TabIndex = 1;
            // 
            // teksAngka2
            // 
            this.teksAngka2.Location = new System.Drawing.Point(30, 141);
            this.teksAngka2.Name = "teksAngka2";
            this.teksAngka2.Size = new System.Drawing.Size(297, 20);
            this.teksAngka2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kalculator Sederhana";
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(30, 270);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(297, 23);
            this.btnKali.TabIndex = 2;
            this.btnKali.Text = "Kali";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(30, 299);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(297, 23);
            this.btnBagi.TabIndex = 2;
            this.btnBagi.Text = "Bagi";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(30, 241);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(297, 23);
            this.btnKurang.TabIndex = 2;
            this.btnKurang.Text = "Kurang";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 335);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.teksAngka2);
            this.Controls.Add(this.teksAngka1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.textAngka2);
            this.Controls.Add(this.textAngka1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textAngka1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label textAngka2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksAngka1;
        private System.Windows.Forms.TextBox teksAngka2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKurang;
    }
}

