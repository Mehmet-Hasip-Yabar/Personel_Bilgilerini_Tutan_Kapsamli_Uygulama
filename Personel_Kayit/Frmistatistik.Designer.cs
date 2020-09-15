namespace Personel_Kayit
{
    partial class Frmistatistik
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
            this.LblToplamPersonel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblEvliPersonel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblBekarPersonel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblSehirSayısı = new System.Windows.Forms.Label();
            this.LblToplamMaas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblOrtalamaMaas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı:";
            // 
            // LblToplamPersonel
            // 
            this.LblToplamPersonel.AutoSize = true;
            this.LblToplamPersonel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamPersonel.Location = new System.Drawing.Point(246, 68);
            this.LblToplamPersonel.Name = "LblToplamPersonel";
            this.LblToplamPersonel.Size = new System.Drawing.Size(20, 24);
            this.LblToplamPersonel.TabIndex = 1;
            this.LblToplamPersonel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evli Personel Sayısı:";
            // 
            // LblEvliPersonel
            // 
            this.LblEvliPersonel.AutoSize = true;
            this.LblEvliPersonel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEvliPersonel.Location = new System.Drawing.Point(246, 129);
            this.LblEvliPersonel.Name = "LblEvliPersonel";
            this.LblEvliPersonel.Size = new System.Drawing.Size(20, 24);
            this.LblEvliPersonel.TabIndex = 3;
            this.LblEvliPersonel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bekar Personel Sayısı:";
            // 
            // LblBekarPersonel
            // 
            this.LblBekarPersonel.AutoSize = true;
            this.LblBekarPersonel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBekarPersonel.Location = new System.Drawing.Point(246, 193);
            this.LblBekarPersonel.Name = "LblBekarPersonel";
            this.LblBekarPersonel.Size = new System.Drawing.Size(20, 24);
            this.LblBekarPersonel.TabIndex = 5;
            this.LblBekarPersonel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şehir Sayısı:";
            // 
            // LblSehirSayısı
            // 
            this.LblSehirSayısı.AutoSize = true;
            this.LblSehirSayısı.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSehirSayısı.Location = new System.Drawing.Point(246, 247);
            this.LblSehirSayısı.Name = "LblSehirSayısı";
            this.LblSehirSayısı.Size = new System.Drawing.Size(20, 24);
            this.LblSehirSayısı.TabIndex = 7;
            this.LblSehirSayısı.Text = "0";
            // 
            // LblToplamMaas
            // 
            this.LblToplamMaas.AutoSize = true;
            this.LblToplamMaas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamMaas.Location = new System.Drawing.Point(246, 295);
            this.LblToplamMaas.Name = "LblToplamMaas";
            this.LblToplamMaas.Size = new System.Drawing.Size(20, 24);
            this.LblToplamMaas.TabIndex = 9;
            this.LblToplamMaas.Text = "0";
            this.LblToplamMaas.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Toplam Maaş:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // LblOrtalamaMaas
            // 
            this.LblOrtalamaMaas.AutoSize = true;
            this.LblOrtalamaMaas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrtalamaMaas.Location = new System.Drawing.Point(246, 338);
            this.LblOrtalamaMaas.Name = "LblOrtalamaMaas";
            this.LblOrtalamaMaas.Size = new System.Drawing.Size(20, 24);
            this.LblOrtalamaMaas.TabIndex = 11;
            this.LblOrtalamaMaas.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 24);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ortalama Maaş:";
            // 
            // Frmistatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 399);
            this.Controls.Add(this.LblOrtalamaMaas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblToplamMaas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblSehirSayısı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblBekarPersonel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblEvliPersonel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblToplamPersonel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frmistatistik";
            this.Text = "Frmistatistik";
            this.Load += new System.EventHandler(this.Frmistatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblToplamPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblEvliPersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblBekarPersonel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblSehirSayısı;
        private System.Windows.Forms.Label LblToplamMaas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblOrtalamaMaas;
        private System.Windows.Forms.Label label12;
    }
}