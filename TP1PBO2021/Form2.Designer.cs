
namespace TP1PBO2021
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
            this.components = new System.ComponentModel.Container();
            this.bthome = new System.Windows.Forms.Button();
            this.btkatalog = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            this.btrangeharga = new System.Windows.Forms.Button();
            this.btjenisharga = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbjenisharga = new System.Windows.Forms.ComboBox();
            this.cbrangeharga = new System.Windows.Forms.ComboBox();
            this.lbjenisharga = new System.Windows.Forms.Label();
            this.lbrangeharga = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btcari = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bthome
            // 
            this.bthome.Location = new System.Drawing.Point(155, 12);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(76, 43);
            this.bthome.TabIndex = 0;
            this.bthome.Text = "Home";
            this.bthome.UseVisualStyleBackColor = true;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // btkatalog
            // 
            this.btkatalog.Location = new System.Drawing.Point(237, 12);
            this.btkatalog.Name = "btkatalog";
            this.btkatalog.Size = new System.Drawing.Size(83, 43);
            this.btkatalog.TabIndex = 1;
            this.btkatalog.Text = "Katalog";
            this.btkatalog.UseVisualStyleBackColor = true;
            // 
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(380, 12);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(75, 43);
            this.btlogout.TabIndex = 2;
            this.btlogout.Text = "Logout";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // btrangeharga
            // 
            this.btrangeharga.Location = new System.Drawing.Point(0, 68);
            this.btrangeharga.Name = "btrangeharga";
            this.btrangeharga.Size = new System.Drawing.Size(75, 53);
            this.btrangeharga.TabIndex = 1;
            this.btrangeharga.Text = "Range Harga";
            this.btrangeharga.UseVisualStyleBackColor = true;
            // 
            // btjenisharga
            // 
            this.btjenisharga.Location = new System.Drawing.Point(0, 4);
            this.btjenisharga.Name = "btjenisharga";
            this.btjenisharga.Size = new System.Drawing.Size(76, 58);
            this.btjenisharga.TabIndex = 0;
            this.btjenisharga.Text = "Jenis Harga";
            this.btjenisharga.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 43);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ini Logo";
            // 
            // cbjenisharga
            // 
            this.cbjenisharga.FormattingEnabled = true;
            this.cbjenisharga.Location = new System.Drawing.Point(12, 87);
            this.cbjenisharga.Name = "cbjenisharga";
            this.cbjenisharga.Size = new System.Drawing.Size(121, 24);
            this.cbjenisharga.TabIndex = 6;
            // 
            // cbrangeharga
            // 
            this.cbrangeharga.FormattingEnabled = true;
            this.cbrangeharga.Location = new System.Drawing.Point(12, 144);
            this.cbrangeharga.Name = "cbrangeharga";
            this.cbrangeharga.Size = new System.Drawing.Size(121, 24);
            this.cbrangeharga.TabIndex = 7;
            // 
            // lbjenisharga
            // 
            this.lbjenisharga.AutoSize = true;
            this.lbjenisharga.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbjenisharga.Location = new System.Drawing.Point(16, 90);
            this.lbjenisharga.Name = "lbjenisharga";
            this.lbjenisharga.Size = new System.Drawing.Size(84, 17);
            this.lbjenisharga.TabIndex = 8;
            this.lbjenisharga.Text = "Jenis Harga";
            // 
            // lbrangeharga
            // 
            this.lbrangeharga.AutoSize = true;
            this.lbrangeharga.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbrangeharga.Location = new System.Drawing.Point(16, 147);
            this.lbrangeharga.Name = "lbrangeharga";
            this.lbrangeharga.Size = new System.Drawing.Size(93, 17);
            this.lbrangeharga.TabIndex = 9;
            this.lbrangeharga.Text = "Range Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "NIM    : 1904480";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama : Andria Nartanto";
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(12, 192);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(75, 23);
            this.btcari.TabIndex = 12;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Semua Barang :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbrangeharga);
            this.Controls.Add(this.lbjenisharga);
            this.Controls.Add(this.cbrangeharga);
            this.Controls.Add(this.cbjenisharga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.btkatalog);
            this.Controls.Add(this.bthome);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthome;
        private System.Windows.Forms.Button btkatalog;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btrangeharga;
        private System.Windows.Forms.Button btjenisharga;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbjenisharga;
        private System.Windows.Forms.ComboBox cbrangeharga;
        private System.Windows.Forms.Label lbjenisharga;
        private System.Windows.Forms.Label lbrangeharga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.Label label4;
    }
}