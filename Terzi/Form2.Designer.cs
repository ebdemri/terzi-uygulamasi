
namespace Terzi
{
    partial class Form2
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
            this.lbKiyafetT = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.sayac1 = new System.Windows.Forms.NumericUpDown();
            this.lbSepet = new System.Windows.Forms.ListBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGenel = new System.Windows.Forms.Label();
            this.btnGenel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sayac1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKiyafetT
            // 
            this.lbKiyafetT.FormattingEnabled = true;
            this.lbKiyafetT.ItemHeight = 15;
            this.lbKiyafetT.Location = new System.Drawing.Point(13, 12);
            this.lbKiyafetT.Name = "lbKiyafetT";
            this.lbKiyafetT.Size = new System.Drawing.Size(120, 214);
            this.lbKiyafetT.TabIndex = 1;
            this.lbKiyafetT.SelectedIndexChanged += new System.EventHandler(this.lbKiyafetT_SelectedIndexChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(13, 263);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(120, 29);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // sayac1
            // 
            this.sayac1.Location = new System.Drawing.Point(13, 234);
            this.sayac1.Name = "sayac1";
            this.sayac1.Size = new System.Drawing.Size(120, 23);
            this.sayac1.TabIndex = 3;
            // 
            // lbSepet
            // 
            this.lbSepet.FormattingEnabled = true;
            this.lbSepet.ItemHeight = 15;
            this.lbSepet.Location = new System.Drawing.Point(212, 12);
            this.lbSepet.Name = "lbSepet";
            this.lbSepet.Size = new System.Drawing.Size(310, 214);
            this.lbSepet.TabIndex = 5;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(13, 361);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(120, 31);
            this.btnSepeteEkle.TabIndex = 6;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ücret :";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(81, 315);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(42, 15);
            this.lblTutar.TabIndex = 8;
            this.lblTutar.Text = "_______";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(201, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Genel Toplam :";
            // 
            // lblGenel
            // 
            this.lblGenel.AutoSize = true;
            this.lblGenel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenel.Location = new System.Drawing.Point(325, 309);
            this.lblGenel.Name = "lblGenel";
            this.lblGenel.Size = new System.Drawing.Size(114, 21);
            this.lblGenel.TabIndex = 10;
            this.lblGenel.Text = "_____________";
            // 
            // btnGenel
            // 
            this.btnGenel.Location = new System.Drawing.Point(212, 246);
            this.btnGenel.Name = "btnGenel";
            this.btnGenel.Size = new System.Drawing.Size(310, 29);
            this.btnGenel.TabIndex = 11;
            this.btnGenel.Text = "Genel Toplam";
            this.btnGenel.UseVisualStyleBackColor = true;
            this.btnGenel.Click += new System.EventHandler(this.btnGenel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "SİPARİŞ ONAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Yeni Satış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenel);
            this.Controls.Add(this.lblGenel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lbSepet);
            this.Controls.Add(this.sayac1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lbKiyafetT);
            this.Name = "Form2";
            this.Text = "Satış Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sayac1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbKiyafetT;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.NumericUpDown sayac1;
        private System.Windows.Forms.ListBox lbSepet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGenel;
        private System.Windows.Forms.Button btnGenel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}