using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public partial class Login : Form
    {
        SqlConnection Sql;
        public Login(SqlConnection sql)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Sql = sql;
            if (Sql.State == ConnectionState.Closed)
            {
                Sql.Open();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select * from [dbo].[User] Where [dbo].[User].[Username]='"+textBox1.Text+ "' and [dbo].[User].[Password]='" + textBox2.Text+"'",Sql);
            SqlDataReader read = com.ExecuteReader();
            if (read.Read())
            {
                string u = read[1].ToString();
                string p = read[2].ToString(); DateTime d = read.GetDateTime(3);
                int userid = int.Parse(read[0].ToString());
                if (int.Parse(read[4].ToString()) ==1)
                {
                    read.Close();
                    this.Hide();
                    new Form1(Sql, new User(userid.ToString(), u, p, d), true).ShowDialog(); this.Show();
                }
                else
                {
                    errorProvider1.Clear();
                    
                    SqlCommand command = new SqlCommand("Select * from [dbo].[KhachHang] where [dbo].[KhachHang].[IdKH]='" + userid.ToString()+"'",Sql);
                    read.Close();
                    read = command.ExecuteReader();
                    
                    if (read.Read())
                    {
                        read.Close();
                        this.Hide();
                        new Form1(Sql, new User(userid.ToString(), u, p, d),false).ShowDialog();
                        this.Show();
                        
                    }
                    else
                    {
                        read.Close();
                        MessageBox.Show("Đăng nhập lần đầu! Vui lòng nhập thông tin!");
                        read.Close();
                        new InfoFillingForm(Sql, userid).ShowDialog();
                        
                    }
                    
                    this.Show();
                    return;
                }
               
                
                
                
            }
            else
            {
                read.Close();
                errorProvider1.SetError(button1, "Incorrect Account!");

            }
            
        }
        private void registerbtn_Click(object sender, EventArgs e)
        {
            if(res_confirmtextbox.Text.Length==0||res_passwordbtn.Text.Length==0||res_usernametextbox.Text.Length==0)
            {
                errorProvider1.SetError(res_passwordbtn, "Vui lòng nhập thông tin!");
                return;
            }
            if (res_usernametextbox.Text.Length < 5 )
            {
                errorProvider1.SetError(res_usernametextbox, "Username must be over 5 charaters");
                return;
            }
            errorProvider1.Clear();
            if (res_passwordbtn.Text[0] > 'a' && res_passwordbtn.Text[0] < 'z')
            {
                errorProvider1.SetError(res_passwordbtn, "First Password's letter must be UPPERCASE!");
            }
            errorProvider1.Clear();
            if(res_passwordbtn.Text!=res_confirmtextbox.Text)
            {
                errorProvider1.SetError(res_confirmtextbox, "Password doesn't match!");
                return;
            }
            errorProvider1.Clear();
            SqlDataReader reader= new SqlCommand("Select * from [dbo].[User] where Username='" + res_usernametextbox.Text + "'", Sql).ExecuteReader();
            if(reader.Read())
            {
                errorProvider1.SetError(registerbtn, "Username already exist! Please try differ Username");
                reader.Close();
                return;
            }
            reader.Close();
            MessageBox.Show(DateTime.Now.Day.ToString());
            new SqlCommand("Insert into [dbo].[User](Username,Password,dateCreated,isAdmin) values('" + res_usernametextbox.Text + "','" + res_passwordbtn.Text+"',convert(date,'"+DateTime.Now.Year.ToString()
               +((DateTime.Now.Month<10)?("0"+DateTime.Now.Month.ToString()):(DateTime.Now.Month.ToString()))+(DateTime.Now.Day<10?("0"+DateTime.Now.Day.ToString()):DateTime.Now.Day.ToString())+"'),"+0+")", Sql).ExecuteNonQuery();
            MessageBox.Show("Đăng kí thành công!");
            
        }
    }
}
