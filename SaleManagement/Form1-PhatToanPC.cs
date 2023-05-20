using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class Form1 : Form
    {
        List<CustomControlChooser> controlChoosers=new List<CustomControlChooser>();


        #region Filter Variables
        ComboButton filteringCompany;
        ComboButton filterPrice;
        ComboButton filterOS;
        List<string> lFilterName=new List<string>();
        int FilterPrice;
        int FilterOS;
        //Button choose companies
        Button[] companies = new Button[] {new Button() {Text="iPhone",Size=new Size(90,30),FlatStyle=FlatStyle.System}, new Button() { Text = "Realme", Size = new Size(90, 30),FlatStyle=FlatStyle.System },
        new Button() {Text="Samsung",Size=new Size(90,30),FlatStyle=FlatStyle.System},new Button() {Text="Oppo",Size=new Size(90,30),FlatStyle=FlatStyle.System}
        ,new Button() {Text="Vivo",Size=new Size(90,30),FlatStyle=FlatStyle.System},new Button() {Text="Xiaomi",Size=new Size(90,30),FlatStyle=FlatStyle.System}};
        // choose for price
        Button[] prices = new Button[] {new Button() { Text = "Dưới 2 triệu",Size = new Size(90, 30),FlatStyle = FlatStyle.System}, new Button() { Text = "Từ 2-4 triệu", Size = new Size(90, 30),FlatStyle = FlatStyle.System },
        new Button() { Text = "Từ 4-7 triệu",Size = new Size(90, 30),FlatStyle = FlatStyle.System},new Button() { Text = "Từ 7-13 triệu",Size = new Size(90, 30),FlatStyle = FlatStyle.System}
        ,new Button() { Text = "Từ 13-20 triệu",Size = new Size(90, 30),FlatStyle = FlatStyle.System},new Button() { Text = "Trên 20 triệu",Size = new Size(90, 30),FlatStyle = FlatStyle.System}
    };
        Button[] typeOSButton = new Button[] { new Button() { Text = "iPhone (IOS)", Size = new Size(90, 30), FlatStyle = FlatStyle.System }, new Button() { Text = "Android", Size = new Size(90, 30), FlatStyle = FlatStyle.System }
        ,new Button() { Text = "Điện thoại phổ thông",Size = new Size(130, 30),FlatStyle = FlatStyle.System}};

        #endregion

        public Form1()
        {
            InitializeComponent();
            //ImageSlideShow slide = new ImageSlideShow(new Image[] {Methods.gatherData_Url("https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-trang-1-2-org.jpg"),
            //    Methods.gatherData_Url("https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-trang-2-1-org.jpg")
            //, Methods.gatherData_Url("https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-trang-4-1-org.jpg"),
            //Methods.gatherData_Url("https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-trang-1-2-org.jpg") }, new Size(400, 300));
            //slide.BringToFront();
            //slide.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AutoSize = false;
            foreach (var ob in companies)
            {
                ob.Click += filterName_Click;
            }
            foreach(var ob in prices)
            {
                ob.Click += filterPrice_Click;
            }
            foreach(var ob in typeOSButton)
            {
                ob.Click += filterType_Click;
            }
            filteringCompany = new ComboButton(2, 3, companies, new Padding(0, 0, 5, 5));
            filterPrice=new ComboButton(2, 4,prices,new Padding(0, 0, 5, 5));
            Point f = controlpointFromThis(searchPanel, priceBtn);
            f.Y += priceBtn.Height;
            filterPrice.Location = f;

            //Pop up form


            /** Filter Popup*/
            filterOS = new ComboButton(1, 3,typeOSButton, new Padding(0, 0, 5, 5));
            Point r = controlpointFromThis(searchPanel, typeSmartPhoneBtn);
            r.Y += typeSmartPhoneBtn.Height;
            filterOS.Location = r;
            Point p = controlpointFromThis(searchPanel, companyBtn);
            p.Y += companyBtn.Height;
            filteringCompany.Location = p;
            Panel panel = new Panel() { BackColor = Color.Transparent, Size = this.Size };
            this.Controls.Add(filteringCompany);
            this.Controls.Add(filterPrice);
            this.Controls.Add(filterOS);
            //filterAll.Visible = false;
            filterPrice.Visible = false;
            filteringCompany.Visible = false;

            ////////////////

            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pictureBox1.Left = textEdit1.Right + 8;
            OvalPictureBox oval = new OvalPictureBox();
            flowLayoutPanel1.Controls.Add(new CustomControlChooser("https://cdn.tgdd.vn/Products/Images/42/258047/samsung-galaxy-z-flip4-5g-128gb-thumb-tim-600x600.jpg", "Samsung Galaxy Z Flip4 5G", "20.990.000\xBđ", 1, "4.6", 0));
            flowLayoutPanel1.Controls.Add(new CustomControlChooser("https://cdn.tgdd.vn/Products/Images/42/153856/iphone-11-trang-600x600.jpg", "iPhone 11", "11.690.000\xBđ", 1, "4.6", 0));
            flowLayoutPanel1.Controls.Add(new CustomControlChooser("https://cdn.tgdd.vn/Products/Images/42/269831/Xiaomi-redmi-note-11-black-600x600.jpeg", "Xiaomi Redmi Note 11", "4.490.000\xBđ", 1, "4.6", 0));
            flowLayoutPanel1.Controls.Add(new CustomControlChooser("https://cdn.tgdd.vn/Products/Images/42/235838/Galaxy-S22-Ultra-Burgundy-600x600.jpg", "Samsung Galaxy S22 Ultra 5G", "25.990.000\xBđ", 1, "4.6", 0));
            flowLayoutPanel1.Controls.Add(new CustomControlChooser("https://cdn.tgdd.vn/Products/Images/42/272668/xiaomi-redmi-note-11s-5g-xanh-lam-thumb-1-600x600.jpg", "iPhone 13 Pro Max", "6.190.000\xBđ", 1, "4.6", 0));
            flowLayoutPanel1.Controls.Add(new CustomControlChooser("https://cdn.tgdd.vn/Products/Images/42/250261/iphone-13-pro-max-xanh-la-thumb-600x600.jpg", "iPhone 14 Pro max 256 GB", "30.990.000\xBđ", 1, "4.6", 0));


        }

        private void filterType_Click(object sender, EventArgs e)
        {
            typeSmartPhoneBtn.Focus();
            Button btn = (Button)sender;
            for (int u = 0; u < typeOSButton.Length; u++)
            {
                if (typeOSButton[u] != btn)
                    typeOSButton[u].FlatStyle = FlatStyle.System;
                else FilterOS = u;
            }
            btn.FlatStyle = FlatStyle.Flat;
        }

        private Point controlpointFromThis(Panel p,Control control)
        {
            return new Point(p.Left + control.Left, p.Top + control.Top);
        }
        private void filterPrice_Click(object sender, EventArgs e)
        {
            priceBtn.Focus();
            Button btn = (Button)sender;
            for(int u=0;u<prices.Length; u++)
            {
                if (prices[u] != btn)
                    prices[u].FlatStyle = FlatStyle.System;
                else FilterPrice = u;
            }
            btn.FlatStyle= FlatStyle.Flat;
            
        }
        private void filterName_Click(object sender ,EventArgs e)
        {
            companyBtn.Focus();
            Button btn = (Button)sender;
            if (btn.FlatStyle == FlatStyle.Flat)
            {
                for (int i = 0; i < lFilterName.Count; i++)
                {
                    if (lFilterName[i] == btn.Text)
                    {
                        lFilterName.RemoveAt(i);
                    }
                }
                btn.FlatStyle = FlatStyle.System;
            }
            else if (btn.FlatStyle == FlatStyle.System)
            {
                lFilterName.Add(btn.Name);
                btn.FlatStyle = FlatStyle.Flat;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void flow_Filtering(string str)
        {
            flowLayoutPanel1.Controls.Clear();
            
        }


        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void ResBtn_Click(object sender, EventArgs e)
        {
        }



        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void toggle_NameFilter(object sender, EventArgs e)
        {
            searchPanel_MouseClick(sender, e);
            filteringCompany.Visible = (filteringCompany.Visible)?false:true;
            filteringCompany.BringToFront();
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {
            searchPanel_MouseClick(sender, e);
            filterPrice.Visible = (filterPrice.Visible) ? false : true;
            filterPrice.BringToFront();
        }

        private void searchPanel_MouseClick(object sender, EventArgs e)
        {
            filteringCompany.Visible = false;
            filterPrice.Visible = false;
            filterOS.Visible = false;
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void typeSmartPhoneBtn_Click(object sender, EventArgs e)
        {
            searchPanel_MouseClick(sender, e); filterOS.BringToFront();
            filterOS.Visible = true;
        }
    }
}
