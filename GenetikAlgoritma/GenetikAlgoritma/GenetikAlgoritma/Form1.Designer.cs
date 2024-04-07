
namespace GenetikAlgoritma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPopulasyon = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCaprazlama = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSeckinlik = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMutasyon = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richSonuc = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnIpucu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownJenerasyon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaprazlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeckinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJenerasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popülasyon Boyutu:";
            // 
            // numericUpDownPopulasyon
            // 
            this.numericUpDownPopulasyon.Location = new System.Drawing.Point(207, 44);
            this.numericUpDownPopulasyon.Name = "numericUpDownPopulasyon";
            this.numericUpDownPopulasyon.Size = new System.Drawing.Size(71, 29);
            this.numericUpDownPopulasyon.TabIndex = 1;
            // 
            // numericUpDownCaprazlama
            // 
            this.numericUpDownCaprazlama.DecimalPlaces = 2;
            this.numericUpDownCaprazlama.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCaprazlama.Location = new System.Drawing.Point(207, 93);
            this.numericUpDownCaprazlama.Name = "numericUpDownCaprazlama";
            this.numericUpDownCaprazlama.Size = new System.Drawing.Size(71, 29);
            this.numericUpDownCaprazlama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çaprazlama Oranı:";
            // 
            // numericUpDownSeckinlik
            // 
            this.numericUpDownSeckinlik.Location = new System.Drawing.Point(207, 192);
            this.numericUpDownSeckinlik.Name = "numericUpDownSeckinlik";
            this.numericUpDownSeckinlik.Size = new System.Drawing.Size(71, 29);
            this.numericUpDownSeckinlik.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(62, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seçkinlik Oranı:";
            // 
            // numericUpDownMutasyon
            // 
            this.numericUpDownMutasyon.DecimalPlaces = 2;
            this.numericUpDownMutasyon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMutasyon.Location = new System.Drawing.Point(207, 143);
            this.numericUpDownMutasyon.Name = "numericUpDownMutasyon";
            this.numericUpDownMutasyon.Size = new System.Drawing.Size(71, 29);
            this.numericUpDownMutasyon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(55, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mutasyon Oranı:";
            // 
            // btnBaslat
            // 
            this.btnBaslat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBaslat.Location = new System.Drawing.Point(29, 28);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(249, 45);
            this.btnBaslat.TabIndex = 8;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(470, 363);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(497, 297);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(36, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Jenerasyon Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(394, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sonuç:";
            // 
            // richSonuc
            // 
            this.richSonuc.Location = new System.Drawing.Point(470, 26);
            this.richSonuc.Name = "richSonuc";
            this.richSonuc.Size = new System.Drawing.Size(497, 290);
            this.richSonuc.TabIndex = 14;
            this.richSonuc.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(29, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTemizle.Location = new System.Drawing.Point(29, 94);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(249, 45);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnIpucu
            // 
            this.btnIpucu.ForeColor = System.Drawing.Color.Maroon;
            this.btnIpucu.Location = new System.Drawing.Point(29, 160);
            this.btnIpucu.Name = "btnIpucu";
            this.btnIpucu.Size = new System.Drawing.Size(249, 45);
            this.btnIpucu.TabIndex = 18;
            this.btnIpucu.Text = "İpucu";
            this.btnIpucu.UseVisualStyleBackColor = true;
            this.btnIpucu.Click += new System.EventHandler(this.btnIpucu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownJenerasyon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownPopulasyon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownCaprazlama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownMutasyon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownSeckinlik);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 304);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBaslat);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnIpucu);
            this.groupBox2.Location = new System.Drawing.Point(33, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 297);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // numericUpDownJenerasyon
            // 
            this.numericUpDownJenerasyon.Location = new System.Drawing.Point(207, 240);
            this.numericUpDownJenerasyon.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownJenerasyon.Name = "numericUpDownJenerasyon";
            this.numericUpDownJenerasyon.Size = new System.Drawing.Size(71, 29);
            this.numericUpDownJenerasyon.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBaslat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1010, 699);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richSonuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaprazlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeckinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJenerasyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulasyon;
        private System.Windows.Forms.NumericUpDown numericUpDownCaprazlama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSeckinlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMutasyon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnIpucu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownJenerasyon;
    }
}

