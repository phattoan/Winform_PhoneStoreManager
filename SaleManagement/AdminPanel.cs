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
    public partial class AdminPanel : UserControl
    {
        SqlConnection connection;
        public AdminPanel(SqlConnection sql)
        {
            InitializeComponent();
            connection = sql;
            loadTable();
        }
        public void loadTable()
        {
            
            dataGridView1.Rows.Clear();
            DataColumn column = new DataColumn("ID Bill");
            DataColumn column1 = new DataColumn("Tên sản phẩm");
            DataColumn column2 = new DataColumn("SL");
            DataColumn column3 = new DataColumn("Giá");
            DataColumn column4 = new DataColumn("Số lượng tồn");
            DataTable table = new DataTable();
            table.Columns.Add(column);
            table.Columns.Add(column1);
            table.Columns.Add(column3);
            table.Columns.Add(column4);
            SqlDataReader reader = new SqlCommand("Select * from Item", connection).ExecuteReader();
            while(reader.Read())
            {
                object[] objects = new object[] { reader[0].ToString(), reader[1].ToString(), reader[5].ToString(), reader[9].ToString() };
                table.Rows.Add(objects);
            }
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            SqlDataReader reader = new SqlCommand("Select ammount from Item where IDItem= " + dataGridView1.Rows[index].Cells[0], connection).ExecuteReader();
            if(reader.Read())
            {
                int n = int.Parse(reader[0].ToString());
                reader.Close();
                if(n==0)
                {
                    new SqlCommand("Delete Item where IDItem= " + dataGridView1.Rows[index].Cells[0], connection).ExecuteNonQuery();

                }
                else
                {
                    new SqlCommand("Update Item Set ammount= "+(n-1).ToString()+" where IDItem= " + dataGridView1.Rows[index].Cells[0], connection).ExecuteNonQuery();

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
            for (int i=0;i<4;i++)
            {
                dataGridView1.Rows[e.RowIndex].Cells[i].Selected = true;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
