namespace SaleManagement
{
    partial class CustomControlChooser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomControlChooser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.installmentTxt = new System.Windows.Forms.Label();
            this.rateText = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.startpic = new System.Windows.Forms.PictureBox();
            this.priceText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.installmentTxt);
            this.panel1.Controls.Add(this.rateText);
            this.panel1.Controls.Add(this.percentage);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Controls.Add(this.startpic);
            this.panel1.Controls.Add(this.priceText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 371);
            this.panel1.TabIndex = 0;
            // 
            // installmentTxt
            // 
            this.installmentTxt.AutoSize = true;
            this.installmentTxt.BackColor = System.Drawing.SystemColors.Control;
            this.installmentTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installmentTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.installmentTxt.Location = new System.Drawing.Point(6, 4);
            this.installmentTxt.Name = "installmentTxt";
            this.installmentTxt.Size = new System.Drawing.Size(65, 15);
            this.installmentTxt.TabIndex = 10;
            this.installmentTxt.Text = "Trả góp 0%";
            // 
            // rateText
            // 
            this.rateText.AutoSize = true;
            this.rateText.BackColor = System.Drawing.Color.White;
            this.rateText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateText.ForeColor = System.Drawing.Color.Tomato;
            this.rateText.Location = new System.Drawing.Point(4, 315);
            this.rateText.Name = "rateText";
            this.rateText.Size = new System.Drawing.Size(26, 17);
            this.rateText.TabIndex = 9;
            this.rateText.Text = "3.8";
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.BackColor = System.Drawing.Color.MistyRose;
            this.percentage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.ForeColor = System.Drawing.Color.Tomato;
            this.percentage.Location = new System.Drawing.Point(94, 284);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(38, 17);
            this.percentage.TabIndex = 8;
            this.percentage.Text = "-13%";
            // 
            // nameText
            // 
            this.nameText.AllowDrop = true;
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(8, 261);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(278, 20);
            this.nameText.TabIndex = 7;
            this.nameText.Text = "awdihawofhawihawofhaioahfiohafawfwf";
            // 
            // startpic
            // 
            this.startpic.Image = ((System.Drawing.Image)(resources.GetObject("startpic.Image")));
            this.startpic.Location = new System.Drawing.Point(36, 315);
            this.startpic.Name = "startpic";
            this.startpic.Size = new System.Drawing.Size(17, 17);
            this.startpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.startpic.TabIndex = 6;
            this.startpic.TabStop = false;
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.ForeColor = System.Drawing.Color.IndianRed;
            this.priceText.Location = new System.Drawing.Point(3, 281);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(59, 22);
            this.priceText.TabIndex = 5;
            this.priceText.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 220);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // CustomControlChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomControlChooser";
            this.Size = new System.Drawing.Size(225, 371);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label rateText;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.PictureBox startpic;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Label installmentTxt;
    }
}
