using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class ItemCartPanel : UserControl
    {
        int oldheight;
        public ItemCartPanel()
        {
            InitializeComponent();
            oldheight = this.Height;
            richTextBox1.Text = "";
            richTextBox1.ReadOnly = true;
            label6_Click(this, new EventArgs());
        }
        DanhSachLuu hoadon;
        public int ammount = 1;
        int pos;
        Item gitem;
        public void initialization(Item item,int pos,DanhSachLuu hoaDon)
        {
            this.pos = pos;
            this.gitem = item;
            this.newprice.Text = item.price;
            this.hoadon = hoaDon;
            pictureBox1.Image = Methods.resize_BitMap(Methods.gatherData_Url(item.portrait), pictureBox1.Size);
            nameItemLbl.Text = item.Name;
            string[] content = item.promo.Split('|');
           foreach(var str in content)
            {
                richTextBox1.Text += "- " + str + '\n';
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            this.Height = oldheight;
            richTextBox1.Visible = false;
            khuyenmailbl.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void khuyenmailbl_Click(object sender, EventArgs e)
        {
            this.Height = label6.Bottom + 50;
            richTextBox1.Visible = true;
            khuyenmailbl.Visible = false;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

            hoadon.removedItem(gitem);
            this.Dispose();
        }

        private void panelNumberic_ValueChanged(object sender, EventArgs e)
        {
            ammount = (int)panelNumberic.Value;
        }
    }
}
