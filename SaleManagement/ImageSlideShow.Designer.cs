namespace SaleManagement
{
    partial class ImageSlideShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageSlideShow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.preBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.preBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 147);
            this.panel1.TabIndex = 0;
            // 
            // preBtn
            // 
            this.preBtn.BackColor = System.Drawing.Color.Transparent;
            this.preBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preBtn.Image = ((System.Drawing.Image)(resources.GetObject("preBtn.Image")));
            this.preBtn.Location = new System.Drawing.Point(3, 57);
            this.preBtn.Name = "preBtn";
            this.preBtn.Size = new System.Drawing.Size(27, 49);
            this.preBtn.TabIndex = 2;
            this.preBtn.UseVisualStyleBackColor = false;
            this.preBtn.Click += new System.EventHandler(this.preBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn.Image")));
            this.nextBtn.Location = new System.Drawing.Point(169, 57);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(30, 30);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.slidePanel.Location = new System.Drawing.Point(138, 164);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(200, 147);
            this.slidePanel.TabIndex = 1;
            // 
            // ImageSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.slidePanel);
            this.Controls.Add(this.panel1);
            this.Name = "ImageSlideShow";
            this.Size = new System.Drawing.Size(399, 311);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button preBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel slidePanel;
    }
}
