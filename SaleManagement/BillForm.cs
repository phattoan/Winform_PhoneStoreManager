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
    public partial class BillForm : Form
    {
        SqlConnection connection; double total = 0;
        public BillForm(SqlConnection sql,KhachHang khach, List<Item> items, List<int> ammount)
        {
            connection = sql;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            DataTable data = new DataTable();
            data.Columns.Add(new DataColumn("Id sản phẩm", typeof(int)));
            data.Columns.Add(new DataColumn("Tên sản phẩm", typeof(string)));
            data.Columns.Add(new DataColumn("SL", typeof(int)));
            data.Columns.Add(new DataColumn("Đơn giá", typeof(string)));
            for (int i = 0; i < items.Count; i++)
            {
                int price = int.Parse(items[i].price.Replace(".", String.Empty).Replace("đ", String.Empty));
                int priceactual = (price - (int)((float)price * (float)((float)items[i].discountPercentage/ (float)100)));
                total +=  priceactual * ammount[i];
                data.Rows.Add(new object[] {items[i].IDItem, items[i].Name, ammount[i], priceactual });
            }
            this.userControl11.initialization(this,sql, khach.getID(),khach.getName(),khach.getAddress(),khach.getPhone(), data, total);
            
        }
    }
}
