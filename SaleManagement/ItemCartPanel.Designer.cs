namespace SaleManagement
{
    partial class ItemCartPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCartPanel));
            this.panelNumberic = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.khuyenmailbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newprice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameItemLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelNumberic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNumberic
            // 
            this.panelNumberic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNumberic.Location = new System.Drawing.Point(538, 68);
            this.panelNumberic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.panelNumberic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.panelNumberic.Name = "panelNumberic";
            this.panelNumberic.Size = new System.Drawing.Size(77, 24);
            this.panelNumberic.TabIndex = 29;
            this.panelNumberic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.panelNumberic.ValueChanged += new System.EventHandler(this.panelNumberic_ValueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(154, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Thu gọn";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // khuyenmailbl
            // 
            this.khuyenmailbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khuyenmailbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.khuyenmailbl.Image = ((System.Drawing.Image)(resources.GetObject("khuyenmailbl.Image")));
            this.khuyenmailbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.khuyenmailbl.Location = new System.Drawing.Point(154, 55);
            this.khuyenmailbl.Name = "khuyenmailbl";
            this.khuyenmailbl.Size = new System.Drawing.Size(110, 23);
            this.khuyenmailbl.TabIndex = 26;
            this.khuyenmailbl.Text = "6 khuyến mãi";
            this.khuyenmailbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.khuyenmailbl.Click += new System.EventHandler(this.khuyenmailbl_Click);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(40, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Xóa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // newprice
            // 
            this.newprice.AutoSize = true;
            this.newprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newprice.ForeColor = System.Drawing.Color.Red;
            this.newprice.Location = new System.Drawing.Point(538, 18);
            this.newprice.Name = "newprice";
            this.newprice.Size = new System.Drawing.Size(77, 16);
            this.newprice.TabIndex = 22;
            this.newprice.Text = "24.990.000đ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(11, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 139);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameItemLbl
            // 
            this.nameItemLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameItemLbl.Location = new System.Drawing.Point(153, 15);
            this.nameItemLbl.Name = "nameItemLbl";
            this.nameItemLbl.Size = new System.Drawing.Size(307, 40);
            this.nameItemLbl.TabIndex = 21;
            this.nameItemLbl.Text = "Name Item";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(157, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 348);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "TextMedaadTextMedaadTextMedaadTextMedaadTextMedaadTextMedaadTextMedaadTextMedaad";
            this.richTextBox1.Visible = false;
            // 
            // ItemCartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelNumberic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.khuyenmailbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newprice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameItemLbl);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ItemCartPanel";
            this.Size = new System.Drawing.Size(628, 207);
            ((System.ComponentModel.ISupportInitialize)(this.panelNumberic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown panelNumberic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label khuyenmailbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label newprice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameItemLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
