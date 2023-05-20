using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SaleManagement
{
    public partial class InfoFillingForm : Form
    {
        SqlConnection connection;
        public InfoFillingForm(SqlConnection sql,int id)
        {
            StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            connection = sql;

            //Adjust positions
            namelable.Location = new Point(nametextbox.Left + 3, nametextbox.Top + 3);
            oldName = namelable.Location;
            nextName=new Point(namelable.Left+7,namelable.Top-17);
            
            addresslable.Location=new Point(addresstextbox.Left+3,addresstextbox.Top+3);
            oldAdd = addresslable.Location;
            nextAdd = new Point(addresslable.Left + 7, addresslable.Top - 20);

            phonelable.Location = new Point(phonetextbox.Left + 3, phonetextbox.Top + 3);
            oldPhone = phonelable.Location;
            nextPhone = new Point(phonelable.Left + 7, phonelable.Top - 17);
            nameTimer = new Timer();
            addTimer = new Timer();
            phoneTimer = new Timer();
            IdKH = id;
        }
        int IdKH;
        Timer nameTimer, addTimer, phoneTimer;
        Point oldName, oldAdd, oldPhone;

        private void namelable_Click(object sender, EventArgs e)
        {
            nametextbox.Focus();
        }

        private void diachilable_Click(object sender, EventArgs e)
        {
            addresstextbox.Focus();
        }

        private void phonelable_Click(object sender, EventArgs e)
        {
            phonetextbox.Focus();
        }

        private void nametextbox_Enter(object sender, EventArgs e)
        {
            if(!nameTimer.Enabled)
            {
                nameTimer = new Timer() { Interval = 1 };
                nameTimer.Tick += NameTimer_Tick;
                nameTimer.Start();
            }
        }

        private void NameTimer_Tick(object sender, EventArgs e)
        {
            if(moveControlbyOne(namelable,nextName))
            {
                nameTimer.Stop();
            }
        }

        private void nametextbox_Leave(object sender, EventArgs e)
        {
            if (!nameTimer.Enabled&&nametextbox.Text.Length==0)
            {
                nameTimer = new Timer() { Interval = 1 };
                nameTimer.Tick += NameTimer_Tick1; ;
                nameTimer.Start();
            }
        }

        private void NameTimer_Tick1(object sender, EventArgs e)
        {
            if (moveControlbyOne(namelable, oldName))
            {
                nameTimer.Stop();
            }
        }

        private void addresstextbox_Enter(object sender, EventArgs e)
        {
            if (!addTimer.Enabled)
            {
                addTimer = new Timer() { Interval = 1 };
                addTimer.Tick += AddTimer_Tick; ;
                addTimer.Start();
            }
        }

        private void AddTimer_Tick(object sender, EventArgs e)
        {
            if (moveControlbyOne(addresslable, nextAdd))
            {
                addTimer.Stop();
            }
        }

        private void addresstextbox_Leave(object sender, EventArgs e)
        {
            if (!addTimer.Enabled && addresstextbox.Text.Length == 0)
            {
                addTimer = new Timer() { Interval = 1 };
                addTimer.Tick += AddTimer_Tick1;
                addTimer.Start();
            }
        }

        private void AddTimer_Tick1(object sender, EventArgs e)
        {
            if (moveControlbyOne(addresslable, oldAdd))
            {
                addTimer.Stop();
            }
        }

        private void phonetextbox_Enter(object sender, EventArgs e)
        {
            if (!phoneTimer.Enabled)
            {
                phoneTimer = new Timer() { Interval = 1 };
                phoneTimer.Tick += PhoneTimer_Tick;
                phoneTimer.Start();
            }
        }

        private void PhoneTimer_Tick(object sender, EventArgs e)
        {
            if (moveControlbyOne(phonelable, nextPhone))
            {
                phoneTimer.Stop();
            }
        }

        private void phonetextbox_Leave(object sender, EventArgs e)
        {
            if (!phoneTimer.Enabled && phonetextbox.Text.Length == 0)
            {
                phoneTimer = new Timer() { Interval = 1 };
                phoneTimer.Tick += PhoneTimer_Tick1; ;
                phoneTimer.Start();
            }
        }

        private void PhoneTimer_Tick1(object sender, EventArgs e)
        {
            if (moveControlbyOne(phonelable, oldPhone))
            {
                phoneTimer.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image =Methods.resize_BitMap( Methods.gatherData_Url(url.Text),pictureBox1.Size);
        }

        Point nextName, nextAdd, nextPhone;
        private void InfoFillingForm_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
        private bool moveControlbyOne(Control con,Point p)
        {
            if(con.Left>p.X)
            {
                con.Left--;
            }
            else if(con.Left<p.X)
            {
                con.Left++;
            }
            if(con.Top<p.Y)
            {
                con.Top++;
            }
            else if(con.Top>p.Y)
            {
                con.Top--;
            }
            if(con.Location==p)
            {
                return true;
            }
            return false;
        }
        private void submitbtn_Click(object sender, EventArgs e)
        {
            if(nametextbox.Text.Length<5)
            {
                errorProvider1.SetError(nametextbox, "Tên phải 5 kí tự trở lên!");
                return;
            }
            errorProvider1.Clear();
            if (addresstextbox.Text.Length<10)
            {
                errorProvider1.SetError(addresstextbox, "Địa chỉ phải 10 kí tự trở lên!");
                return;
            }
            errorProvider1.Clear();
            if (phonetextbox.Text.Length == 0)
            {
                errorProvider1.SetError(phonetextbox, "Vui lòng nhập số điện thoại!");
                return;
            }
            errorProvider1.Clear();
            if (url.Text.Length==0)
            {
                errorProvider1.SetError(url, "Vui long bo anh!");
                return;
            }
            errorProvider1.Clear();
            if (!int.TryParse(phonetextbox.Text,out _))
            {
                errorProvider1.SetError(phonetextbox, "Số điện thoại không đúng!");
                return;
            }
            errorProvider1.Clear();
            if (!radioButton1.Checked&&!radioButton2.Checked)
            {
                errorProvider1.SetError(radioButton2, "Vui lòng chọn giới tính!");
                return;
            }
            errorProvider1.Clear();
            byte[] imageData=Methods.ConvertImageToBytes(Methods.gatherData_Url(url.Text));
            using (SqlCommand command= new SqlCommand("Insert into KhachHang values(@id,@name,@address,@phone,@gender,@image)", connection))
            {
                command.Parameters.AddWithValue("@id", IdKH.ToString());
                command.Parameters.AddWithValue("@name",nametextbox.Text);
                command.Parameters.AddWithValue("@address",addresstextbox.Text);
                command.Parameters.AddWithValue("@phone",phonetextbox.Text);
                command.Parameters.AddWithValue("@gender", ((radioButton1.Checked) ? 1 : 0));
                command.Parameters.AddWithValue("@image",imageData);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Cập nhật thông tin thành công", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
