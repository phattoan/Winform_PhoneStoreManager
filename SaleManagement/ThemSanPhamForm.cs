using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class ThemSanPhamForm : Form
    {
        SqlConnection connection;
        public ThemSanPhamForm(SqlConnection sql)
        {
            connection = sql;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            typeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            if(sql.State==ConnectionState.Closed)
            {
                sql.Open();
            }
        }
        List<Image> images = new List<Image>();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               Image image=Methods.resize_BitMap( Methods.gatherData_Url(UrlTextbox.Text),pictureBox2.Size);
                images.Add(image);
                pictureBox2.Image = image;
                comboBox1.Items.Add(UrlTextbox.Text);

            }
            catch(Exception)
            {
                pictureBox2.Image = null;
                
                MessageBox.Show("Ảnh không thích hợp, vui lòng thay đổi địa chỉ!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex>0)
            {
                images.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                pictureBox2.Image = null;
            }
            
        }
        string portrait="";
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                portrait = UrlTextbox2.Text;
                Image image = Methods.resize_BitMap(Methods.gatherData_Url(UrlTextbox2.Text), pictureBox1.Size);
                pictureBox1.Image = image;
            }
            catch (Exception)
            {
                portrait = "";
                pictureBox1.Image = null;
                MessageBox.Show("Ảnh không thích hợp, vui lòng thay đổi địa chỉ!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{
            errorProvider1.Clear();
            if (images.Count != comboBox1.Items.Count)
            {
                MessageBox.Show("Lỗi ảnh sản phẩm không trùng khớp với dữ liệu! Xóa hết ảnh hiện tại và thử thêm lại!");
                return;
            }
            if (typeCombobox.SelectedIndex == -1)
            {
                errorProvider1.SetError(typeCombobox, "Vui long chọn hãng điện thoại!");
                return;
            }
            errorProvider1.Clear();
            if (portrait == "")
            {
                errorProvider1.SetError(pictureBox1, "Vui lòng thêm ảnh");
                return;
            }
            errorProvider1.Clear();
            if (images.Count == 0)
            {
                errorProvider1.SetError(pictureBox2, "Vui lòng thêm ít nhất 1 ảnh"); return;
            }
            errorProvider1.Clear();
            if (screenTextbox.Text.Length == 0)
            {
                errorProvider1.SetError(screenTextbox, "Vui lòng điền thông tin!"); return;
            }
            errorProvider1.Clear();
            if (osTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(osTextBox, "Vui lòng điền thông tin!"); return;
            }
            errorProvider1.Clear();
            if (camsauText.Text.Length == 0)
            {
                errorProvider1.SetError(camsauText, "Vui lòng điền thông tin!"); return;
            }
            errorProvider1.Clear();
            if (camtruocText.Text.Length == 0)
            {
                errorProvider1.SetError(camtruocText, "Vui lòng điền thông tin!"); return;
            }
            errorProvider1.Clear();
            if (chipText.Text.Length == 0)
            {
                errorProvider1.SetError(chipText, "Vui lòng điền thông tin!"); return;
            }

            errorProvider1.Clear();

            SqlDataReader reader = new SqlCommand("Select COUNT(*) from Item", connection).ExecuteReader();
            reader.Read();
            int n = int.Parse(reader[0].ToString());
            n++;
            reader.Close();
            string des = "";
            string promo = "";
            foreach (var ob in richTextBox1.Text)
            {
                if (ob == '\n')
                {
                    promo += "|";
                }
                else promo += ob;
            }
            foreach (var ob in richTextBox2.Text)
            {
                if (ob == '\n')
                {
                    des += "|";
                }
                else des += ob;
            }
            string apdaterstr = "Insert into Item values(" + n.ToString() + ",N'" + nameTextBox.Text + "',N'" + promo + "',N'" + des + "'," + 5.ToString() + ",N'" + priceText.Text + "đ" + "'," + discountNumberic.Value.ToString() +
                "," + installment.Value.ToString() + ",N'" + portrait + "'," + numericUpDown1.Value.ToString() + ")";
            new SqlCommand(apdaterstr, connection).ExecuteNonQuery();
            string typeadapter = "INSERT [dbo].[TypeDevice] ([IDType],[Type], [Screen], [OS], [frontCam], [backCam], [Chip], [Ram], [Capacity], [Battery]) VALUES(" + n.ToString() + ",'" + typeCombobox.SelectedItem + "',N'" +
                screenTextbox.Text + "',N'" + osTextBox.Text + "',N'" + camtruocText.Text + "',N'" + camsauText.Text + "',N'" + chipText.Text + "'," + numericRam.Value.ToString() + "," + dungluongNumeric.Value.ToString() + "," + pinNumeric.Value.ToString() + ")";
            new SqlCommand(typeadapter, connection).ExecuteNonQuery();
            foreach (var ob in comboBox1.Items)
            {
                new SqlCommand("INSERT [dbo].[DeviceImage] ([DeviceID], [URLImage]) values(" + n.ToString() + ",'" + ob.ToString() + "')", connection).ExecuteNonQuery();
            }
            MessageBox.Show("Thêm sản phẩm thành công!");
            this.Close();
        }
            //catch(Exception)
            //{
            //    MessageBox.Show("Lỗi khi thêm sản phẩm, vui lòng kiểm tra thông tin!");

            //}
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = images[comboBox1.SelectedIndex];
        }
    }
}
