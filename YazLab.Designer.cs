namespace YazLab
{
    partial class YazLab
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazLab));
            this.Dosyaac = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dosya_yolu = new System.Windows.Forms.Label();
            this.resim = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.en_al = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boy_al = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.play_stop = new System.Windows.Forms.Button();
            this.format = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.goster = new System.Windows.Forms.Button();
            this.frame_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.SuspendLayout();
            // 
            // Dosyaac
            // 
            this.Dosyaac.Image = ((System.Drawing.Image)(resources.GetObject("Dosyaac.Image")));
            this.Dosyaac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dosyaac.Location = new System.Drawing.Point(12, 53);
            this.Dosyaac.Name = "Dosyaac";
            this.Dosyaac.Size = new System.Drawing.Size(133, 28);
            this.Dosyaac.TabIndex = 1;
            this.Dosyaac.Text = "Dosya Aç";
            this.Dosyaac.UseVisualStyleBackColor = true;
            this.Dosyaac.Click += new System.EventHandler(this.Dosyaac_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 46);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(760, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "YUV CONVERTER";
            // 
            // Dosya_yolu
            // 
            this.Dosya_yolu.AutoSize = true;
            this.Dosya_yolu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dosya_yolu.Location = new System.Drawing.Point(9, 93);
            this.Dosya_yolu.Name = "Dosya_yolu";
            this.Dosya_yolu.Size = new System.Drawing.Size(0, 13);
            this.Dosya_yolu.TabIndex = 3;
            // 
            // resim
            // 
            this.resim.Location = new System.Drawing.Point(250, 53);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(386, 339);
            this.resim.TabIndex = 4;
            this.resim.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bmp Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // en_al
            // 
            this.en_al.Location = new System.Drawing.Point(12, 191);
            this.en_al.Name = "en_al";
            this.en_al.Size = new System.Drawing.Size(50, 20);
            this.en_al.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "En:";
            // 
            // boy_al
            // 
            this.boy_al.Location = new System.Drawing.Point(12, 254);
            this.boy_al.Name = "boy_al";
            this.boy_al.Size = new System.Drawing.Size(50, 20);
            this.boy_al.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Boy:";
            // 
            // play_stop
            // 
            this.play_stop.FlatAppearance.BorderSize = 0;
            this.play_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_stop.Image = ((System.Drawing.Image)(resources.GetObject("play_stop.Image")));
            this.play_stop.Location = new System.Drawing.Point(410, 398);
            this.play_stop.Name = "play_stop";
            this.play_stop.Size = new System.Drawing.Size(65, 46);
            this.play_stop.TabIndex = 10;
            this.play_stop.UseVisualStyleBackColor = true;
            this.play_stop.Click += new System.EventHandler(this.play_stop_Click);
            // 
            // format
            // 
            this.format.FormattingEnabled = true;
            this.format.Items.AddRange(new object[] {
            "4:4:4",
            "4:2:2",
            "4:2:0"});
            this.format.Location = new System.Drawing.Point(12, 323);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(74, 21);
            this.format.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Format:";
            // 
            // goster
            // 
            this.goster.Location = new System.Drawing.Point(12, 398);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(75, 23);
            this.goster.TabIndex = 13;
            this.goster.Text = "Göster";
            this.goster.UseVisualStyleBackColor = true;
            this.goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // frame_label
            // 
            this.frame_label.AutoSize = true;
            this.frame_label.Location = new System.Drawing.Point(551, 415);
            this.frame_label.Name = "frame_label";
            this.frame_label.Size = new System.Drawing.Size(0, 13);
            this.frame_label.TabIndex = 14;
            // 
            // YazLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frame_label);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.format);
            this.Controls.Add(this.play_stop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boy_al);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.en_al);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resim);
            this.Controls.Add(this.Dosya_yolu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dosyaac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YazLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YazLab";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Dosyaac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Dosya_yolu;
        private System.Windows.Forms.PictureBox resim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox en_al;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boy_al;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button play_stop;
        private System.Windows.Forms.ComboBox format;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button goster;
        private System.Windows.Forms.Label frame_label;
    }
}

