namespace Personel_Çağırma
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "List Box\'u Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "En Yüksek Maaşlı Personelin Adını Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 95);
            this.button3.TabIndex = 2;
            this.button3.Text = "Toplam ödenen Maaş Tutarını Göster";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 95);
            this.button4.TabIndex = 3;
            this.button4.Text = "Toplam Personel Sayısını Göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(192, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 95);
            this.button5.TabIndex = 4;
            this.button5.Text = "Maaşı 4000 TL\' den Az Olan Personel İsimlerini Listele";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(192, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 95);
            this.button6.TabIndex = 5;
            this.button6.Text = "Listedeki 3. Elemanın Maaşını 500 TL Arttır";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(332, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 95);
            this.button7.TabIndex = 6;
            this.button7.Text = "En Düşük Maaşı Göster";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(332, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 95);
            this.button8.TabIndex = 7;
            this.button8.Text = "Maaşı 5000 TL - 7000 TL Arası Personel Sayısını Göster";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(331, 263);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(134, 95);
            this.button9.TabIndex = 8;
            this.button9.Text = "Son Personelin Adını Yazdır";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(37, 27);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(308, 39);
            this.button10.TabIndex = 10;
            this.button10.Text = "Oluştur ve Listele";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 342);
            this.listBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Personel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(210, 431);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(58, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Ekle";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Location = new System.Drawing.Point(544, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 427);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(373, 62);
            this.button13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 51);
            this.button13.TabIndex = 17;
            this.button13.Text = "100\'e kadar onlar basamağı 7 Olan Sayılar";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(373, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(396, 227);
            this.button14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 19);
            this.button14.TabIndex = 19;
            this.button14.Text = "Form2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(396, 141);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 42);
            this.button12.TabIndex = 16;
            this.button12.Text = "Başlığı Değiştir";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 582);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button12;
    }
}

