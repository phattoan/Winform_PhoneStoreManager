using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class DanhSachLuu : Form
    {
        SqlConnection connection;
        List<Item> lItems;
        List<ItemCartPanel> carts = new List<ItemCartPanel>();
        public DanhSachLuu(KhachHang user,List<Item> lItems,SqlConnection sql)
        {
            StartPosition = FormStartPosition.CenterScreen;
            connection = sql;
            this.lItems = lItems;
            gUser = user;
            InitializeComponent();
            for(int i=0;i< lItems.Count;i++)
            {
                ItemCartPanel itemCartPanel = new ItemCartPanel();
                itemCartPanel.initialization(lItems[i],i,this); ;
                carts.Add(itemCartPanel);
                flowList.Controls.Add(itemCartPanel);
            }
            flowList.Left = (this.Width / 2) - (flowList.Width / 2);
        }
        public void removedItem(Item item)
        {
            lItems.Remove(item);

        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        KhachHang gUser;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(lItems.Count==0)
            {
                MessageBox.Show("Chưa có sản phẩm được thêm để mua!");
                return;
            }
            List<int> ints = new List<int>();
            foreach (var i in carts)
            {
                ints.Add(i.ammount);
            }
            new BillForm(connection,gUser, lItems, ints).ShowDialog();
        }
    }
}
