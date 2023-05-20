namespace SaleManagement
{
    partial class InfoFillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoFillingForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.namelable = new System.Windows.Forms.Label();
            this.addresslable = new System.Windows.Forms.Label();
            this.phonelable = new System.Windows.Forms.Label();
            this.phonetextbox = new System.Windows.Forms.TextBox();
            this.addresstextbox = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.submitbtn = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextbox.Location = new System.Drawing.Point(35, 209);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(267, 22);
            this.nametextbox.TabIndex = 1;
            this.nametextbox.Enter += new System.EventHandler(this.nametextbox_Enter);
            this.nametextbox.Leave += new System.EventHandler(this.nametextbox_Leave);
            // 
            // namelable
            // 
            this.namelable.AutoSize = true;
            this.namelable.BackColor = System.Drawing.Color.Transparent;
            this.namelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelable.Location = new System.Drawing.Point(39, 211);
            this.namelable.Name = "namelable";
            this.namelable.Size = new System.Drawing.Size(70, 16);
            this.namelable.TabIndex = 0;
            this.namelable.Text = "Họ và Tên";
            this.namelable.Click += new System.EventHandler(this.namelable_Click);
            // 
            // addresslable
            // 
            this.addresslable.AutoSize = true;
            this.addresslable.BackColor = System.Drawing.Color.Transparent;
            this.addresslable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslable.Location = new System.Drawing.Point(39, 265);
            this.addresslable.Name = "addresslable";
            this.addresslable.Size = new System.Drawing.Size(47, 16);
            this.addresslable.TabIndex = 2;
            this.addresslable.Text = "Địa chỉ";
            this.addresslable.Click += new System.EventHandler(this.diachilable_Click);
            // 
            // phonelable
            // 
            this.phonelable.AutoSize = true;
            this.phonelable.BackColor = System.Drawing.Color.Transparent;
            this.phonelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelable.Location = new System.Drawing.Point(34, 411);
            this.phonelable.Name = "phonelable";
            this.phonelable.Size = new System.Drawing.Size(85, 16);
            this.phonelable.TabIndex = 5;
            this.phonelable.Text = "Số điện thoại";
            this.phonelable.Click += new System.EventHandler(this.phonelable_Click);
            // 
            // phonetextbox
            // 
            this.phonetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetextbox.Location = new System.Drawing.Point(35, 408);
            this.phonetextbox.Name = "phonetextbox";
            this.phonetextbox.Size = new System.Drawing.Size(100, 22);
            this.phonetextbox.TabIndex = 6;
            this.phonetextbox.Enter += new System.EventHandler(this.phonetextbox_Enter);
            this.phonetextbox.Leave += new System.EventHandler(this.phonetextbox_Leave);
            // 
            // addresstextbox
            // 
            this.addresstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstextbox.Location = new System.Drawing.Point(37, 262);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(266, 123);
            this.addresstextbox.TabIndex = 7;
            this.addresstextbox.Text = "";
            this.addresstextbox.Enter += new System.EventHandler(this.addresstextbox_Enter);
            this.addresstextbox.Leave += new System.EventHandler(this.addresstextbox_Leave);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(152, 410);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(205, 411);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(226, 448);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(99, 38);
            this.submitbtn.TabIndex = 10;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // url
            // 
            this.url.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url.Location = new System.Drawing.Point(23, 29);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(267, 22);
            this.url.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoFillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.url);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.phonelable);
            this.Controls.Add(this.addresslable);
            this.Controls.Add(this.namelable);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addresstextbox);
            this.Controls.Add(this.phonetextbox);
            this.Name = "InfoFillingForm";
            this.Text = "InfoFillingFOrm";
            this.Click += new System.EventHandler(this.InfoFillingForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label namelable;
        private System.Windows.Forms.Label addresslable;
        private System.Windows.Forms.Label phonelable;
        private System.Windows.Forms.TextBox phonetextbox;
        private System.Windows.Forms.RichTextBox addresstextbox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox url;
    }
}