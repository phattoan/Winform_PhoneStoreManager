using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class CustomControlChooser : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        /// <summary>
        /// Tao danh muc moi cho dien thoai
        /// </summary>
        /// <param name="image">Anh cho san pham 205x230</param>
        /// <param name="Name">Ten san pham</param>
        /// <param name="Price">Gia san pham</param>
        /// <param name="percentage">Giam gia %</param>
        /// <param name="rate">So danh gia</param>
        /// <param name="installment">Tra gop %</param>
        /// 
        Item gItem=null;
        List<Item> lItem;
        public CustomControlChooser(Item item,List<Item> items)
        {
            lItem = items;
            InitializeComponent();
            gItem = item;
            this.panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height
            ,15,15))    ;
            if(gItem!=null)
            {
                
                this.nameText.Top = pictureBox1.Bottom + 10;
                this.nameText.Text = gItem.Name;
                if(nameText.Width>pictureBox1.Width)
                {
                    nameText.AutoSize = false;
                    nameText.Size = new Size(pictureBox1.Width, nameText.Height * 2);
                }
                this.priceText.Text = gItem.price;
                this.priceText.Top = this.nameText.Bottom + 10;
                this.percentage.Text = "-" + gItem.discountPercentage + "%";
                this.percentage.Left = this.priceText.Right + 5;
                this.percentage.Top = (this.priceText.Height / 2) + this.priceText.Top - (this.percentage.Height / 2);
                this.rateText.Text = gItem.rating.ToString();
                this.rateText.Top = this.priceText.Bottom + 7;
                this.rateText.Left = priceText.Left;
                startpic.Top = rateText.Top;
                startpic.Left = rateText.Right + 3;
                this.Height = this.rateText.Bottom + 10;
                this.Margin = new Padding(20, 10, 10, 10);
                pictureBox1.Image = Methods.resize_BitMap(Methods.gatherData_Url(gItem.portrait), pictureBox1.Width, pictureBox1.Height);
            }
            
        }
        bool isHover = false;
        
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if(isHover==true)
            {
                return;
            }
            pictureBox1.Top = pictureBox1.Top - 10; nameText.ForeColor = SystemColors.Highlight;
            this.Cursor=Cursors.Hand;
            isHover = true;
        }


        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if(isHover==false)
            {
                return;
            }
            pictureBox1.Top = pictureBox1.Top + 10;
            nameText.ForeColor = SystemColors.ControlText;
            this.Cursor = Cursors.Default;
            isHover = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] strings = gItem.promo.Split('|');
            List<string> promo=new List<string>();
            foreach(string s in strings)
            {
                promo.Add(s);
            }
            List<string> des=new List<string>();
            string[] content = gItem.Description.Split('|');
            foreach(string ob in content)
            {
                des.Add(ob);
            }
            ItemDetailForm item = new ItemDetailForm(gItem,promo,des,lItem);
            item.Show();
        }
    }
}
