namespace tekmi_çift_mi__96
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
            this.lblSayi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.lblPuan = new System.Windows.Forms.Label();
            this.btnTek = new System.Windows.Forms.Button();
            this.btnCift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı:";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.Location = new System.Drawing.Point(113, 73);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(25, 25);
            this.lblSayi.TabIndex = 1;
            this.lblSayi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puan:";
            // 
            // btnUret
            // 
            this.btnUret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.Location = new System.Drawing.Point(166, 73);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(130, 38);
            this.btnUret.TabIndex = 5;
            this.btnUret.Text = "Sayı Üret";
            this.btnUret.UseVisualStyleBackColor = false;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(113, 165);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(25, 25);
            this.lblPuan.TabIndex = 6;
            this.lblPuan.Text = "0";
            // 
            // btnTek
            // 
            this.btnTek.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTek.Location = new System.Drawing.Point(30, 249);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(120, 23);
            this.btnTek.TabIndex = 3;
            this.btnTek.Text = "Tek Sayı";
            this.btnTek.UseVisualStyleBackColor = false;
            this.btnTek.Click += new System.EventHandler(this.btnTek_Click);
            // 
            // btnCift
            // 
            this.btnCift.BackColor = System.Drawing.Color.Yellow;
            this.btnCift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCift.Location = new System.Drawing.Point(166, 249);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(130, 23);
            this.btnCift.TabIndex = 7;
            this.btnCift.Text = "Çift Sayı";
            this.btnCift.UseVisualStyleBackColor = false;
            this.btnCift.Click += new System.EventHandler(this.btnCift_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(345, 330);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sayı Oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.Button btnCift;
    }
}

