using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsControlLibrary2;
using System.Data;
using System.Net;

namespace SaleManagement
{
    public partial class Form1 : Form
    {
        List<CustomControlChooser> controlChoosers = new List<CustomControlChooser>();
        #region Data Variables
        List<Item> items = new List<Item>();
        SqlConnection connection;
        bool isAdmin = false;
        List<Item> itemsCaches = new List<Item>();//List holding temporary item when bought for user
        List<Item> itemsSave = new List<Item>(); //List of saved items for user
        User gUser;
        KhachHang khach = new KhachHang();
        #endregion
        #region Filter Variables
        ComboButton filteringCompany;
        ComboButton filteringPrice;
        ComboButton filterOS;
        //Login PartialForm
        Login _Partiallogin;
        List<string> lFilterCompany = new List<string>();
        List<string> lFilterPrice = new List<string>();
        List<string> lFilterType = new List<string>();
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
        };
        int[] intprice = new int[] { 2000000, 4000000, 7000000, 13000000, 20000000 };

        #endregion

        public Form1(SqlConnection sql, User user, bool isAdmin)
        {
            connection = sql;
            this.isAdmin = isAdmin;
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            ///Gather data
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            filteringCompany = new ComboButton(2, 3, companies, new Padding(0, 0, 5, 5));
            filteringPrice = new ComboButton(2, 4, prices, new Padding(0, 0, 5, 5));
            Point f = controlpointFromThis(searchPanel, priceBtn);
            f.Y += priceBtn.Height;
            filteringPrice.Location = f;

            //Pop up form


            /** Filter Popup*/
            filterOS = new ComboButton(1, 2, typeOSButton, new Padding(0, 0, 5, 5));
            gUser = user;
            Point r = controlpointFromThis(searchPanel, typeSmartPhoneBtn);
            r.Y += typeSmartPhoneBtn.Height;
            filterOS.Location = r;
            Point p = controlpointFromThis(searchPanel, companyBtn);
            p.Y += companyBtn.Height;
            filteringCompany.Location = p;
            Panel panel = new Panel() { BackColor = Color.Transparent, Size = this.Size };
            this.Controls.Add(filteringCompany);
            this.Controls.Add(filteringPrice);
            this.Controls.Add(filterOS);
            //filterAll.Visible = false;
            filteringPrice.Visible = false;
            filteringCompany.Visible = false;
            filterOS.Visible = false;
            filterOS.BringToFront();
            filteringPrice.BringToFront();
            filteringCompany.BringToFront();
            pictureBox1.Left = textEdit1.Right + 8;

            //Load User
            if (isAdmin)
            {
                nameuserlbl.ForeColor = Color.DarkRed;
                ListBill.Visible = false;
                toolStrip1.Visible = false;
            }

            else
            {
                //Load Item
                readData();
                SqlDataReader reader = new SqlCommand("Select * from KhachHang where IdKH=" + user.getID(), connection).ExecuteReader();
                reader.Read();
                khach = new KhachHang(int.Parse(
                    reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), (int.Parse(reader[4].ToString()) == 1) ? true : false,
                    (byte[])reader.GetValue(5)); reader.Close();
                pictureBox2.Image =Methods.ScaleImageToFit( khach.getPortrait(),pictureBox2.Width,pictureBox2.Height);
                pictureBox2.Size = pictureBox2.Image.Size;
            }


            nameuserlbl.Text = user.getName();

            userpanel.Controls.Add(groupBox1);
            userpanel.Visible = false;
            userpanel.Size = flowLayoutPanel1.Size;
            this.userpanel.Controls.Add(groupBox2);
            groupBox2.Visible = true;
            if (!isAdmin)
            {
                groupBox2.Dispose();
            }
            else
                groupBox1.Dispose();
            this.Controls.Add(userpanel);
            this.Controls.Add(ListBill);
            this.Form1_SizeChanged(this, new EventArgs());
        }
        bool isClicked = false;
        /// <summary>
        /// Read items in directory from Server
        /// </summary>
        /// <param name="Path"></param>
        private void readData()
        {
            flowLayoutPanel1.Controls.Clear();

            Dictionary<int, List<string>> lstrings = new Dictionary<int, List<string>>();
            int i = int.Parse(new SqlCommand("Select MIN(DeviceID) from DeviceImage", connection).ExecuteScalar().ToString());
            SqlDataReader reader = new SqlCommand("select * from [dbo].[DeviceImage] Order By [dbo].[DeviceImage].DeviceID", connection).ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {

                if (i != int.Parse(reader[0].ToString()))
                {
                    lstrings.Add(i, new List<string>(list));
                    i = int.Parse(reader[0].ToString());
                    list.Clear();
                }
                list.Add(reader[1].ToString());

            }
            lstrings.Add(i, list);
            reader.Close();
            reader = new SqlCommand("Select * from [dbo].[Item] Inner Join[dbo].[TypeDevice] On[dbo].[Item].IDItem =[dbo].[TypeDevice].IDType ORDER BY[dbo].[Item].IDItem; ", connection)
               .ExecuteReader();
            while (reader.Read())
            {
                
                if (reader.GetInt32(9) > 0)
                {
                    if (isClicked)
                    {
                        
                        bool searchFlag = false;
                        int l = textEdit1.Text.Length;
                        string name = reader[1].ToString();
                        for (int ii = 0; ii < name.Length - l + 1; ii++)
                        {
                            string n = name.Substring(ii, l);
                            if (textEdit1.Text == n)
                            {
                                searchFlag = true;
                                break;

                            }
                        }
                        if (searchFlag == false)
                            continue;

                    }
                    string company = reader[11].ToString();
                    int price =int.Parse( reader[5].ToString().Replace(".",string.Empty).Replace("đ",String.Empty));
                    string os = reader[13].ToString();
                    bool flagcom = true;
                    bool flagprice = true;
                    bool flagos = true;
                    if(filteringCompany.count>0)
                    {
                        flagcom = false;
                        for (int h = 0; h < filteringCompany.list.Length; h++)
                        {
                            if (filteringCompany.list[h])
                            {
                                flagcom = (company == companies[h].Text);
                                if (flagcom) break;
                            }
                        }
                    }
                    if(filterOS.count>0)
                    {
                        flagos = os.Substring(0, 3) == "iOS" && filterOS.list[0];
                        string o = os.Substring(0, 7);
                        flagos = o == "Android" && filterOS.list[1]||flagos;
                    }
                    if(filteringPrice.count>0)
                    {
                        flagprice = false;
                        int leftbound = 0;
                        for (int ii = 0; ii < filteringPrice.list.Length - 1; ii++)
                        {
                            if (filteringPrice.list[ii])
                            {

                                flagprice = (price >= leftbound && price <= intprice[ii]);
                                if (flagprice == true) break;
                            }
                            leftbound = intprice[ii];
                        }
                        if(!flagprice&& filteringPrice.list[5])
                        flagprice =price >= 20000000;
                        
                    }
                    
                    
                    if (!(flagcom&&flagprice&&flagos))
                    {
                        
                        continue;
                    }
                    Item item = new Item(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                    , float.Parse(reader[4].ToString()), reader[5].ToString(), int.Parse(reader[6].ToString())
                    , int.Parse(reader[7].ToString()), reader[8].ToString(),
                    new TypeDevice(reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(),
                    reader[16].ToString(), int.Parse(reader[17].ToString()), int.Parse(reader[18].ToString()), int.Parse(reader[19].ToString()), lstrings[int.Parse(reader[0].ToString())]));
                    items.Add(item);
                    flowLayoutPanel1.Controls.Add(new CustomControlChooser(item, itemsSave));
                }

            }
            isClicked = false;
            reader.Close();
        }
        private Point controlpointFromThis(Panel p, Control control)
        {
            return new Point(p.Left + control.Left, p.Top + control.Top);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            isClicked = false;
            textEdit1.Text = "";
            unFocusAllFilteringPopUp();
            readData();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Location = new Point(0, searchPanel.Bottom);
            ListBill.Location = flowLayoutPanel1.Location; ListBill.Size = flowLayoutPanel1.Size;
            try
            {
                userpanel.Location = ListBill.Location;

                userpanel.Size = flowLayoutPanel1.Size;
            }
            catch (Exception)
            {

            }
            groupBox1.Location = new Point((this.userpanel.Width / 2) - (groupBox1.Width / 2), (userpanel.Height / 2) - (groupBox1.Height / 2));
            try
            {
                groupBox2.Location = new Point((this.userpanel.Width / 2) - (groupBox2.Width / 2), (userpanel.Height / 2) - (groupBox2.Height / 2));
            }
            catch (Exception)
            {

            }
        }

        private void taohoadonbtn_Click(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
            new DanhSachLuu(khach, itemsSave, connection).Show();

        }
        List<int> lists; int total;
        private object[] gatherBill(int id, int amount)
        {
            SqlDataReader reader = new SqlCommand("Select * from Item where [IDItem]=" + id.ToString(), connection).ExecuteReader();
            reader.Read();
            total = int.Parse(reader[5].ToString().Replace(".", String.Empty).Replace("đ", String.Empty)) * amount;
            object[] objects = new object[] { reader[0].ToString(), reader[1].ToString(), amount, reader[5].ToString() }; reader.Close();
            reader.Close();
            return objects
            ;
        }
        bool billistoggle = false;
        FlowLayoutPanel ListBill = new FlowLayoutPanel() { BackColor = Color.Gray, AutoScroll = true, FlowDirection = FlowDirection.LeftToRight };
        private void dshoadonbtn_Click(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
            if (!billistoggle)
            {
                ListBill.Controls.Clear();
                ListBill.Visible = true;
                ListBill.BringToFront();
                SqlDataReader data = new SqlCommand("Select * from [Bill] where IdKH=" + gUser.getID(), connection).ExecuteReader();
                lists = new List<int>();
                List<int> listBill = new List<int>();
                while (data.Read())
                {
                    listBill.Add(int.Parse(data[0].ToString()));
                }
                data.Close();
                foreach (var ob in listBill)
                {
                    this.ListBill.Controls.Add(createBill(ob));
                }
                billistoggle = true;
            }
            else
            {
                ListBill.Visible = false;
                billistoggle = false;
            }

        }

        private UserControl1 createBill(int id)
        {
            lists.Clear();
            total = 0;
            DataTable data = new DataTable();
            List<int> ids = new List<int>();
            List<int> amount = new List<int>();
            data.Columns.Add(new DataColumn("Id sản phẩm", typeof(int)));
            data.Columns.Add(new DataColumn("Tên sản phẩm", typeof(string)));
            data.Columns.Add(new DataColumn("SL", typeof(int)));
            data.Columns.Add(new DataColumn("Đơn giá", typeof(string)));
            SqlDataReader reader = new SqlCommand("Select * from DETAILEDBILL where IdBill=" + id.ToString(), connection).ExecuteReader();
            while (reader.Read())
            {
                ids.Add(int.Parse(reader[1].ToString()));
                amount.Add(int.Parse(reader[2].ToString()));
            }
            reader.Close();
            for (var ob = 0; ob < ids.Count; ob++)
            {
                data.Rows.Add(gatherBill(ids[ob], amount[ob]));
            }
            reader = new SqlCommand("Select * from Bill where idBill=" + id, connection).ExecuteReader();
            reader.Read();
            UserControl1 userControl1 = new UserControl1() { Size = new Size(455, 473), BorderStyle = BorderStyle.FixedSingle };
            int ID = int.Parse(reader[0].ToString());
            string name = reader[3].ToString(); string address = reader[5].ToString();
            string phone = reader[4].ToString(); DateTime date = reader.GetDateTime(2); reader.Close();

            userControl1.loadBill(ID, name, address, phone, date, data, total);

            return userControl1;
        }
        Panel userpanel = new Panel();
        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (nametextbox.Text.Length < 5)
            {
                errorProvider1.SetError(nametextbox, "Tên phải 5 kí tự trở lên!");
                return;
            }
            errorProvider1.Clear();
            if (addresstextbox.Text.Length < 10)
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
            if (!int.TryParse(phonetextbox.Text, out _) || phonetextbox.Text.Length != 10)
            {
                errorProvider1.SetError(phonetextbox, "Số điện thoại không đúng!");
                return;
            }
            errorProvider1.Clear();
            using (SqlCommand command = new SqlCommand("Update KhachHang Set Name = @name, Address = @address, Phonenum = @phone, Gender =@gender Where IdKH = " + gUser.getID(),connection))
            {
                command.Parameters.AddWithValue("@name", nametextbox.Text);
                command.Parameters.AddWithValue("@address", addresstextbox.Text);
                command.Parameters.AddWithValue("@phone", phonetextbox.Text);
                command.Parameters.AddWithValue("@gender", ((radioButton1.Checked) ? 1 : 0));
                //command.Parameters.AddWithValue("@image", pictureBox2.Ima);
                command.ExecuteNonQuery();
            }
            khach = new KhachHang(int.Parse(gUser.getID()), nametextbox.Text, addresstextbox.Text, phonetextbox.Text, (radioButton1.Checked) ? true : false, khach.getPortrait());
            MessageBox.Show("Cập nhật thông tin thành công!");
        }

        private void nameuserlbl_LinkClicked(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
            if (userpanel.Visible)
            {
                userpanel.Visible = false;

            }
            else
            {

                userpanel.BringToFront();

                userpanel.Visible = true;
                if (!isAdmin)
                {
                    nametextbox.Text = khach.getName();
                    phonetextbox.Text = khach.getPhone();
                    addresstextbox.Text = khach.getAddress();
                    radioButton1.Checked = khach.isMan();
                    radioButton2.Checked = !khach.isMan();

                }
                else
                {
                    loadDataGrid();
                }
                userpanel.BringToFront();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            new ThemSanPhamForm(connection).ShowDialog();
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            SqlDataReader reader = new SqlCommand("Select count(*) from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Item';", connection).ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close(); reader = new SqlCommand("select * from Item inner join TypeDevice on IDItem=IDType", connection).ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("ID"));
            table.Columns.Add(new DataColumn("Name"));
            table.Columns.Add(new DataColumn("Promotion"));
            table.Columns.Add(new DataColumn("Description"));
            table.Columns.Add(new DataColumn("Rating"));
            table.Columns.Add(new DataColumn("Price"));
            table.Columns.Add(new DataColumn("Discount Percentage"));
            table.Columns.Add(new DataColumn("Installment Percentage"));
            table.Columns.Add(new DataColumn("Portrait"));
            table.Columns.Add(new DataColumn("Ammount"));
            table.Columns.Add(new DataColumn("Type"));
            table.Columns.Add(new DataColumn("Screen"));
            table.Columns.Add(new DataColumn("OS"));
            table.Columns.Add(new DataColumn("Front Camera"));
            table.Columns.Add(new DataColumn("Back Camera"));
            table.Columns.Add(new DataColumn("Chip"));
            table.Columns.Add(new DataColumn("Ram"));
            table.Columns.Add(new DataColumn("Capacity"));
            table.Columns.Add(new DataColumn("Battery"));

            while (reader.Read())
            {
                object[] obs = new object[19] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString(),reader[17].ToString(),
                reader[18].ToString(),reader[19].ToString()};
                table.Rows.Add(obs);

            }
            adminItemManageGrid.DataSource = table;
            adminItemManageGrid.Columns["ID"].ReadOnly = true;
            reader.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Việc này sẽ thay thế dữ liệu trên hệ thống bằng dữ liệu trên  bảng, bạn muốn chắc muốn xử lý?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }
            if (MessageBox.Show("Một phần số dữ liệu được thay thế có thể sẽ không phù hợp với hệ thống, nhiều phần sẽ gây ra lỗi, vẫn tiếp tục xử lý?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Format The Server's Data
                new SqlCommand("Delete Item", connection).ExecuteNonQuery();
                new SqlCommand("Delete TypeDevice", connection).ExecuteNonQuery();
                //Upload current data to server
                for (int i = 0; i < adminItemManageGrid.Rows.Count - 1; i++)
                {

                    string apdaterstr = "Insert into Item values(" + adminItemManageGrid.Rows[i].Cells[0].Value.ToString() + ",N'" + adminItemManageGrid.Rows[i].Cells[1].Value.ToString() + "',N'" + adminItemManageGrid.Rows[i].Cells[2].Value.ToString()
                        + "',N'" + adminItemManageGrid.Rows[i].Cells[3].Value.ToString() + "'," + adminItemManageGrid.Rows[i].Cells[4].Value.ToString().Replace(',', '.') + ",N'" + adminItemManageGrid.Rows[i].Cells[5].Value.ToString() + "',"
                        + adminItemManageGrid.Rows[i].Cells[6].Value.ToString() +
            "," + adminItemManageGrid.Rows[i].Cells[7].Value.ToString() + ",N'" + adminItemManageGrid.Rows[i].Cells[8].Value.ToString() + "'," + adminItemManageGrid.Rows[i].Cells[9].Value.ToString() + ")";
                    new SqlCommand(apdaterstr, connection).ExecuteNonQuery();
                    string typeadapter = "INSERT [dbo].[TypeDevice] ([IDType],[Type], [Screen], [OS], [frontCam], [backCam], [Chip], [Ram], [Capacity], [Battery]) VALUES(" + adminItemManageGrid.Rows[i].Cells[0].Value.ToString()
                        + ",'" + adminItemManageGrid.Rows[i].Cells[10].Value.ToString() + "',N'" +
                        adminItemManageGrid.Rows[i].Cells[11].Value.ToString() + "',N'" + adminItemManageGrid.Rows[i].Cells[12].Value.ToString() + "',N'" + adminItemManageGrid.Rows[i].Cells[13].Value.ToString()
                        + "',N'" + adminItemManageGrid.Rows[i].Cells[14].Value.ToString() + "',N'" + adminItemManageGrid.Rows[i].Cells[15].Value.ToString() + "'," + adminItemManageGrid.Rows[i].Cells[16].Value.ToString()
                        + "," + adminItemManageGrid.Rows[i].Cells[17].Value.ToString() + "," + adminItemManageGrid.Rows[i].Cells[18].Value.ToString() + ")";
                    new SqlCommand(typeadapter, connection).ExecuteNonQuery();
                }
                MessageBox.Show("Thêm dữ liệu thành công", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private bool cursorisInControl(Point e,Control control)
        {
            label1.Text = e.ToString();
            return e.X >= control.Left-2 && e.X <= control.Right+2 && e.Y >= control.Top-2 && e.Y <= control.Bottom+2&&control.Visible;
        }
        private void unFocusAllFilteringPopUp()
        {
            filteringPrice.Visible = false;
            filteringCompany.Visible = false;
            filterOS.Visible = false;
        }
        private void companyBtn_Click(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
            filteringCompany.Visible = true;
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
            filteringPrice.Visible = true;

        }

        private void typeSmartPhoneBtn_Click(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
            filterOS.Visible = true;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
        }

        private void searchPanel_Click(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
        }

        private void textEdit1_Enter(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
        }

        private void tittle_Click(object sender, EventArgs e)
        {
            unFocusAllFilteringPopUp();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            isClicked = true;
            unFocusAllFilteringPopUp();
            readData();
        }

        private void nameuserlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
