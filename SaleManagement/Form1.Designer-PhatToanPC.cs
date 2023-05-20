using System.Windows.Forms;

namespace SaleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl1 = new System.Windows.Forms.Panel();
            this.textEdit1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tittle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.typeSmartPhoneBtn = new System.Windows.Forms.Button();
            this.priceBtn = new System.Windows.Forms.Button();
            this.companyBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usernamelbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Location = new System.Drawing.Point(720, 15);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(342, 36);
            this.panelControl1.TabIndex = 4;
            // 
            // textEdit1
            // 
            this.textEdit1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Location = new System.Drawing.Point(3, 5);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(288, 26);
            this.textEdit1.TabIndex = 4;
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 0);
            this.panel2.TabIndex = 9;
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.Color.Gold;
            this.tittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tittle.Controls.Add(this.usernamelbl);
            this.tittle.Controls.Add(this.label1);
            this.tittle.Controls.Add(this.pictureBox3);
            this.tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tittle.Location = new System.Drawing.Point(0, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(1374, 69);
            this.tittle.TabIndex = 10;
            this.tittle.Click += new System.EventHandler(this.searchPanel_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sale Management";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.typeSmartPhoneBtn);
            this.searchPanel.Controls.Add(this.priceBtn);
            this.searchPanel.Controls.Add(this.companyBtn);
            this.searchPanel.Controls.Add(this.filterBtn);
            this.searchPanel.Controls.Add(this.panelControl1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 69);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1374, 66);
            this.searchPanel.TabIndex = 12;
            this.searchPanel.Click += new System.EventHandler(this.searchPanel_MouseClick);
            // 
            // typeSmartPhoneBtn
            // 
            this.typeSmartPhoneBtn.BackColor = System.Drawing.Color.White;
            this.typeSmartPhoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeSmartPhoneBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.typeSmartPhoneBtn.Location = new System.Drawing.Point(295, 19);
            this.typeSmartPhoneBtn.Name = "typeSmartPhoneBtn";
            this.typeSmartPhoneBtn.Size = new System.Drawing.Size(98, 29);
            this.typeSmartPhoneBtn.TabIndex = 8;
            this.typeSmartPhoneBtn.Text = "Loại điện thoại";
            this.typeSmartPhoneBtn.UseVisualStyleBackColor = false;
            this.typeSmartPhoneBtn.Click += new System.EventHandler(this.typeSmartPhoneBtn_Click);
            // 
            // priceBtn
            // 
            this.priceBtn.BackColor = System.Drawing.Color.White;
            this.priceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priceBtn.Location = new System.Drawing.Point(202, 19);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(67, 29);
            this.priceBtn.TabIndex = 7;
            this.priceBtn.Text = "Giá";
            this.priceBtn.UseVisualStyleBackColor = false;
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // companyBtn
            // 
            this.companyBtn.BackColor = System.Drawing.Color.White;
            this.companyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.companyBtn.Location = new System.Drawing.Point(111, 19);
            this.companyBtn.Name = "companyBtn";
            this.companyBtn.Size = new System.Drawing.Size(67, 29);
            this.companyBtn.TabIndex = 6;
            this.companyBtn.Text = "Hãng";
            this.companyBtn.UseVisualStyleBackColor = false;
            this.companyBtn.Click += new System.EventHandler(this.toggle_NameFilter);
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.White;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterBtn.Image")));
            this.filterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterBtn.Location = new System.Drawing.Point(23, 19);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(67, 29);
            this.filterBtn.TabIndex = 5;
            this.filterBtn.Text = "Bộ lọc";
            this.filterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1063, 666);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.searchPanel_MouseClick);
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(1266, 26);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(85, 20);
            this.usernamelbl.TabIndex = 8;
            this.usernamelbl.TabStop = true;
            this.usernamelbl.Text = "UserName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1374, 801);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.tittle.ResumeLayout(false);
            this.tittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelControl1;
        private System.Windows.Forms.TextBox textEdit1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel tittle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Label label1;
        private Panel searchPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button filterBtn;
        private Button companyBtn;
        private Button priceBtn;
        private Button typeSmartPhoneBtn;
        private LinkLabel usernamelbl;
    }
}

