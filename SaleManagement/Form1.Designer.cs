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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl1 = new System.Windows.Forms.Panel();
            this.textEdit1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tittle = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.taohoadonbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dshoadonbtn = new System.Windows.Forms.ToolStripButton();
            this.nameuserlbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.phonelable = new System.Windows.Forms.Label();
            this.addresslable = new System.Windows.Forms.Label();
            this.namelable = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addresstextbox = new System.Windows.Forms.RichTextBox();
            this.phonetextbox = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.typeSmartPhoneBtn = new System.Windows.Forms.Button();
            this.priceBtn = new System.Windows.Forms.Button();
            this.companyBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.adminItemManageGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tittle.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminItemManageGrid)).BeginInit();
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
            this.panelControl1.Location = new System.Drawing.Point(353, 15);
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
            this.textEdit1.Enter += new System.EventHandler(this.textEdit1_Enter);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1401, 0);
            this.panel2.TabIndex = 9;
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.BackColor = System.Drawing.Color.Gold;
            this.tittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tittle.Controls.Add(this.toolStrip1);
            this.tittle.Controls.Add(this.nameuserlbl);
            this.tittle.Controls.Add(this.label1);
            this.tittle.Controls.Add(this.pictureBox3);
            this.tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tittle.Location = new System.Drawing.Point(0, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(1401, 69);
            this.tittle.TabIndex = 10;
            this.tittle.Click += new System.EventHandler(this.tittle_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taohoadonbtn,
            this.toolStripSeparator1,
            this.dshoadonbtn});
            this.toolStrip1.Location = new System.Drawing.Point(265, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(358, 65);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // taohoadonbtn
            // 
            this.taohoadonbtn.AutoSize = false;
            this.taohoadonbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.taohoadonbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.taohoadonbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taohoadonbtn.Image = ((System.Drawing.Image)(resources.GetObject("taohoadonbtn.Image")));
            this.taohoadonbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.taohoadonbtn.Margin = new System.Windows.Forms.Padding(15, 1, 15, 2);
            this.taohoadonbtn.Name = "taohoadonbtn";
            this.taohoadonbtn.Size = new System.Drawing.Size(120, 50);
            this.taohoadonbtn.Text = "Tạo Giao Dịch";
            this.taohoadonbtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.taohoadonbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.taohoadonbtn.Click += new System.EventHandler(this.taohoadonbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 65);
            // 
            // dshoadonbtn
            // 
            this.dshoadonbtn.AutoSize = false;
            this.dshoadonbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dshoadonbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dshoadonbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshoadonbtn.Image = ((System.Drawing.Image)(resources.GetObject("dshoadonbtn.Image")));
            this.dshoadonbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dshoadonbtn.Margin = new System.Windows.Forms.Padding(15, 1, 15, 2);
            this.dshoadonbtn.Name = "dshoadonbtn";
            this.dshoadonbtn.Size = new System.Drawing.Size(150, 50);
            this.dshoadonbtn.Text = "Danh sách hóa đơn";
            this.dshoadonbtn.Click += new System.EventHandler(this.dshoadonbtn_Click);
            // 
            // nameuserlbl
            // 
            this.nameuserlbl.AutoSize = true;
            this.nameuserlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameuserlbl.Location = new System.Drawing.Point(1271, 26);
            this.nameuserlbl.Name = "nameuserlbl";
            this.nameuserlbl.Size = new System.Drawing.Size(83, 20);
            this.nameuserlbl.TabIndex = 9;
            this.nameuserlbl.TabStop = true;
            this.nameuserlbl.Text = "Username";
            this.nameuserlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nameuserlbl_LinkClicked);
            this.nameuserlbl.Click += new System.EventHandler(this.nameuserlbl_LinkClicked);
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
            this.searchPanel.Controls.Add(this.groupBox1);
            this.searchPanel.Controls.Add(this.typeSmartPhoneBtn);
            this.searchPanel.Controls.Add(this.priceBtn);
            this.searchPanel.Controls.Add(this.companyBtn);
            this.searchPanel.Controls.Add(this.filterBtn);
            this.searchPanel.Controls.Add(this.panelControl1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 69);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1401, 66);
            this.searchPanel.TabIndex = 12;
            this.searchPanel.Click += new System.EventHandler(this.searchPanel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.phonelable);
            this.groupBox1.Controls.Add(this.addresslable);
            this.groupBox1.Controls.Add(this.namelable);
            this.groupBox1.Controls.Add(this.nametextbox);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.addresstextbox);
            this.groupBox1.Controls.Add(this.phonetextbox);
            this.groupBox1.Controls.Add(this.submitbtn);
            this.groupBox1.Location = new System.Drawing.Point(775, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 484);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID: ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(204, 392);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(151, 391);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // phonelable
            // 
            this.phonelable.AutoSize = true;
            this.phonelable.BackColor = System.Drawing.Color.Transparent;
            this.phonelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelable.Location = new System.Drawing.Point(38, 369);
            this.phonelable.Name = "phonelable";
            this.phonelable.Size = new System.Drawing.Size(85, 16);
            this.phonelable.TabIndex = 25;
            this.phonelable.Text = "Số điện thoại";
            // 
            // addresslable
            // 
            this.addresslable.AutoSize = true;
            this.addresslable.BackColor = System.Drawing.Color.Transparent;
            this.addresslable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslable.Location = new System.Drawing.Point(38, 224);
            this.addresslable.Name = "addresslable";
            this.addresslable.Size = new System.Drawing.Size(47, 16);
            this.addresslable.TabIndex = 24;
            this.addresslable.Text = "Địa chỉ";
            // 
            // namelable
            // 
            this.namelable.AutoSize = true;
            this.namelable.BackColor = System.Drawing.Color.Transparent;
            this.namelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelable.Location = new System.Drawing.Point(38, 171);
            this.namelable.Name = "namelable";
            this.namelable.Size = new System.Drawing.Size(70, 16);
            this.namelable.TabIndex = 21;
            this.namelable.Text = "Họ và Tên";
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextbox.Location = new System.Drawing.Point(34, 190);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(267, 22);
            this.nametextbox.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 129);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // addresstextbox
            // 
            this.addresstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstextbox.Location = new System.Drawing.Point(36, 243);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(266, 123);
            this.addresstextbox.TabIndex = 27;
            this.addresstextbox.Text = "";
            // 
            // phonetextbox
            // 
            this.phonetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetextbox.Location = new System.Drawing.Point(34, 389);
            this.phonetextbox.Name = "phonetextbox";
            this.phonetextbox.Size = new System.Drawing.Size(100, 22);
            this.phonetextbox.TabIndex = 26;
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(225, 429);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(99, 38);
            this.submitbtn.TabIndex = 30;
            this.submitbtn.Text = "Thay đổi";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // typeSmartPhoneBtn
            // 
            this.typeSmartPhoneBtn.BackColor = System.Drawing.Color.White;
            this.typeSmartPhoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeSmartPhoneBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.typeSmartPhoneBtn.Location = new System.Drawing.Point(226, 17);
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
            this.priceBtn.Location = new System.Drawing.Point(153, 17);
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
            this.companyBtn.Location = new System.Drawing.Point(78, 17);
            this.companyBtn.Name = "companyBtn";
            this.companyBtn.Size = new System.Drawing.Size(67, 29);
            this.companyBtn.TabIndex = 6;
            this.companyBtn.Text = "Hãng";
            this.companyBtn.UseVisualStyleBackColor = false;
            this.companyBtn.Click += new System.EventHandler(this.companyBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.White;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Image = ((System.Drawing.Image)(resources.GetObject("filterBtn.Image")));
            this.filterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterBtn.Location = new System.Drawing.Point(5, 17);
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1401, 666);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.adminItemManageGrid);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(48, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1326, 401);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhấn vào ô để thay đổi thông tin trực tiếp";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1197, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lưu dữ liệu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thông tin";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // adminItemManageGrid
            // 
            this.adminItemManageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminItemManageGrid.Location = new System.Drawing.Point(13, 36);
            this.adminItemManageGrid.Name = "adminItemManageGrid";
            this.adminItemManageGrid.Size = new System.Drawing.Size(1304, 291);
            this.adminItemManageGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm sản phẩm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1401, 801);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.tittle.ResumeLayout(false);
            this.tittle.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminItemManageGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelControl1;
        private System.Windows.Forms.TextBox textEdit1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel tittle;
        private Panel searchPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button filterBtn;
        private Button companyBtn;
        private Button priceBtn;
        private Button typeSmartPhoneBtn;
        private LinkLabel nameuserlbl;
        private ToolStrip toolStrip1;
        private ToolStripButton taohoadonbtn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton dshoadonbtn;
        private Label label1;
        private PictureBox pictureBox3;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label phonelable;
        private Label addresslable;
        private Label namelable;
        private TextBox nametextbox;
        private PictureBox pictureBox2;
        private RichTextBox addresstextbox;
        private TextBox phonetextbox;
        private Button submitbtn;
        private GroupBox groupBox2;
        private Button button3;
        private DataGridView adminItemManageGrid;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}

