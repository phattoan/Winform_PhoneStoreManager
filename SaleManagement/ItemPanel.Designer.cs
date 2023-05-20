namespace SaleManagement
{
    partial class ItemPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageSlideShow1 = new WindowsFormsControlLibrary1.ImageSlideShow();
            this.thongtingroup = new System.Windows.Forms.GroupBox();
            this.thongtintextbox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.promogroup = new System.Windows.Forms.GroupBox();
            this.promotextbox = new System.Windows.Forms.RichTextBox();
            this.titlepanel = new System.Windows.Forms.Panel();
            this.namelbl = new System.Windows.Forms.Label();
            this.thongsogroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pinlbl = new System.Windows.Forms.Label();
            this.dungluonglbl = new System.Windows.Forms.Label();
            this.ramlbl = new System.Windows.Forms.Label();
            this.chiplbl = new System.Windows.Forms.Label();
            this.camerasaulbl = new System.Windows.Forms.Label();
            this.cameratruoclbl = new System.Windows.Forms.Label();
            this.OSlbl = new System.Windows.Forms.Label();
            this.manhinhlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.thongtingroup.SuspendLayout();
            this.promogroup.SuspendLayout();
            this.thongsogroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.imageSlideShow1);
            this.panel1.Controls.Add(this.thongtingroup);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.promogroup);
            this.panel1.Controls.Add(this.titlepanel);
            this.panel1.Controls.Add(this.namelbl);
            this.panel1.Controls.Add(this.thongsogroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 900);
            this.panel1.TabIndex = 0;
            // 
            // imageSlideShow1
            // 
            this.imageSlideShow1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imageSlideShow1.Location = new System.Drawing.Point(17, 56);
            this.imageSlideShow1.Name = "imageSlideShow1";
            this.imageSlideShow1.Size = new System.Drawing.Size(620, 441);
            this.imageSlideShow1.TabIndex = 9;
            // 
            // thongtingroup
            // 
            this.thongtingroup.Controls.Add(this.thongtintextbox);
            this.thongtingroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtingroup.Location = new System.Drawing.Point(17, 518);
            this.thongtingroup.Name = "thongtingroup";
            this.thongtingroup.Size = new System.Drawing.Size(620, 355);
            this.thongtingroup.TabIndex = 8;
            this.thongtingroup.TabStop = false;
            this.thongtingroup.Text = "Thông tin sản phẩm";
            // 
            // thongtintextbox
            // 
            this.thongtintextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thongtintextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongtintextbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtintextbox.Location = new System.Drawing.Point(3, 18);
            this.thongtintextbox.Name = "thongtintextbox";
            this.thongtintextbox.Size = new System.Drawing.Size(614, 334);
            this.thongtintextbox.TabIndex = 1;
            this.thongtintextbox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(663, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(467, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm vào danh sách";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // promogroup
            // 
            this.promogroup.Controls.Add(this.promotextbox);
            this.promogroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.promogroup.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promogroup.ForeColor = System.Drawing.Color.Brown;
            this.promogroup.Location = new System.Drawing.Point(663, 60);
            this.promogroup.Name = "promogroup";
            this.promogroup.Size = new System.Drawing.Size(476, 373);
            this.promogroup.TabIndex = 5;
            this.promogroup.TabStop = false;
            this.promogroup.Text = "15.000.000d";
            // 
            // promotextbox
            // 
            this.promotextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.promotextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotextbox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promotextbox.Location = new System.Drawing.Point(3, 28);
            this.promotextbox.Name = "promotextbox";
            this.promotextbox.Size = new System.Drawing.Size(470, 342);
            this.promotextbox.TabIndex = 0;
            this.promotextbox.Text = "";
            // 
            // titlepanel
            // 
            this.titlepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlepanel.Location = new System.Drawing.Point(18, 48);
            this.titlepanel.Name = "titlepanel";
            this.titlepanel.Size = new System.Drawing.Size(1047, 2);
            this.titlepanel.TabIndex = 4;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(12, 21);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(117, 25);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Name Item\\";
            // 
            // thongsogroup
            // 
            this.thongsogroup.AutoSize = true;
            this.thongsogroup.Controls.Add(this.tableLayoutPanel1);
            this.thongsogroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongsogroup.Location = new System.Drawing.Point(663, 518);
            this.thongsogroup.Name = "thongsogroup";
            this.thongsogroup.Size = new System.Drawing.Size(492, 355);
            this.thongsogroup.TabIndex = 0;
            this.thongsogroup.TabStop = false;
            this.thongsogroup.Text = "Thông số kỹ thuật";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.pinlbl, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dungluonglbl, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ramlbl, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.chiplbl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.camerasaulbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cameratruoclbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.OSlbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.manhinhlbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 334);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pinlbl
            // 
            this.pinlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pinlbl.AutoSize = true;
            this.pinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinlbl.Location = new System.Drawing.Point(156, 302);
            this.pinlbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.pinlbl.Name = "pinlbl";
            this.pinlbl.Size = new System.Drawing.Size(0, 16);
            this.pinlbl.TabIndex = 15;
            this.pinlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dungluonglbl
            // 
            this.dungluonglbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dungluonglbl.AutoSize = true;
            this.dungluonglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungluonglbl.Location = new System.Drawing.Point(156, 259);
            this.dungluonglbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.dungluonglbl.Name = "dungluonglbl";
            this.dungluonglbl.Size = new System.Drawing.Size(0, 16);
            this.dungluonglbl.TabIndex = 14;
            this.dungluonglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramlbl
            // 
            this.ramlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ramlbl.AutoSize = true;
            this.ramlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramlbl.Location = new System.Drawing.Point(156, 218);
            this.ramlbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.ramlbl.Name = "ramlbl";
            this.ramlbl.Size = new System.Drawing.Size(0, 16);
            this.ramlbl.TabIndex = 13;
            this.ramlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chiplbl
            // 
            this.chiplbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chiplbl.AutoSize = true;
            this.chiplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiplbl.Location = new System.Drawing.Point(156, 177);
            this.chiplbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.chiplbl.Name = "chiplbl";
            this.chiplbl.Size = new System.Drawing.Size(0, 16);
            this.chiplbl.TabIndex = 12;
            this.chiplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camerasaulbl
            // 
            this.camerasaulbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.camerasaulbl.AutoSize = true;
            this.camerasaulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camerasaulbl.Location = new System.Drawing.Point(156, 136);
            this.camerasaulbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.camerasaulbl.Name = "camerasaulbl";
            this.camerasaulbl.Size = new System.Drawing.Size(0, 16);
            this.camerasaulbl.TabIndex = 11;
            this.camerasaulbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cameratruoclbl
            // 
            this.cameratruoclbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cameratruoclbl.AutoSize = true;
            this.cameratruoclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameratruoclbl.Location = new System.Drawing.Point(156, 95);
            this.cameratruoclbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.cameratruoclbl.Name = "cameratruoclbl";
            this.cameratruoclbl.Size = new System.Drawing.Size(0, 16);
            this.cameratruoclbl.TabIndex = 10;
            this.cameratruoclbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OSlbl
            // 
            this.OSlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OSlbl.AutoSize = true;
            this.OSlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSlbl.Location = new System.Drawing.Point(156, 54);
            this.OSlbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.OSlbl.Name = "OSlbl";
            this.OSlbl.Size = new System.Drawing.Size(0, 16);
            this.OSlbl.TabIndex = 9;
            this.OSlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manhinhlbl
            // 
            this.manhinhlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manhinhlbl.AutoSize = true;
            this.manhinhlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manhinhlbl.Location = new System.Drawing.Point(156, 13);
            this.manhinhlbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.manhinhlbl.Name = "manhinhlbl";
            this.manhinhlbl.Size = new System.Drawing.Size(0, 16);
            this.manhinhlbl.TabIndex = 8;
            this.manhinhlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Màn hình:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hệ điều hành:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Camera sau:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Camera trước:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pin, Sac:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Dung lượng lưu trữ:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ram:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Chip:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ItemPanel";
            this.Size = new System.Drawing.Size(1171, 900);
            this.SizeChanged += new System.EventHandler(this.ItemPanel_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.thongtingroup.ResumeLayout(false);
            this.promogroup.ResumeLayout(false);
            this.thongsogroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.GroupBox thongsogroup;
        private System.Windows.Forms.Label pinlbl;
        private System.Windows.Forms.Label dungluonglbl;
        private System.Windows.Forms.Label ramlbl;
        private System.Windows.Forms.Label chiplbl;
        private System.Windows.Forms.Label camerasaulbl;
        private System.Windows.Forms.Label cameratruoclbl;
        private System.Windows.Forms.Label OSlbl;
        private System.Windows.Forms.Label manhinhlbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox promogroup;
        private System.Windows.Forms.Panel titlepanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox thongtingroup;
        private System.Windows.Forms.RichTextBox thongtintextbox;
        private System.Windows.Forms.RichTextBox promotextbox;
        private WindowsFormsControlLibrary1.ImageSlideShow imageSlideShow1;
    }
}
