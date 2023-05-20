using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.SqlServer.Server;
using System.Drawing;
using System.IO;

namespace SaleManagement
{
    public class HoaDon
    {
        private string idHD;
        private  int IDKhachHang;
        private  int IDNguoiTao;
        private  DateTime NgayTao;
        private  int HanBaoHanh;
        private  List<Item> items;
        private  int gia;
        private HoaDon(User user, string idHD, int kh, int nguoitao, DateTime tao, int bh, List<Item> items, int gia)
        {
            string temp = new string(idHD.ToCharArray());
            this.idHD = idHD;
            this.IDKhachHang = kh;
            this.IDNguoiTao = nguoitao;
            this.NgayTao = tao;
            this.HanBaoHanh = bh;
            this.items = items;
            this.gia = gia;
            
            typeof(User).GetMethod("themLichSu", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(user, new object[] {temp.Length==0? ("Tạo mới hoa đơn số: " + idHD) : ("Tạo mới hoa đơn số: "+temp+"-->" + idHD) });
        }
        public bool isEqual(HoaDon don)
        {
            return this.IDKhachHang == don.IDKhachHang && this.IDNguoiTao == don.IDNguoiTao
                && this.NgayTao == don.NgayTao && this.HanBaoHanh == don.HanBaoHanh&&this.gia==don.gia;
        }
    }
    public class User
    {
        protected string IDUser;
        protected string Username;
        protected string Password;
        protected List<string> history;
        private DateTime dateCreate;
        public User(string id,string username, string password, DateTime dateCreate)
        {
            IDUser = id;
            Username = username;
            Password = password;
            this.dateCreate = dateCreate;
            history = new List<string>();
        }

        public string getName()
        {
            return this.Username;
        }
        public string getID()
        {
            return this.IDUser;
        }
        private void themLichSu(string str)
        {
            history.Add(str);
        }
        public List<string> layLichSu()
        {
            return history;
        }
        public HoaDon createHoaDon(int kh,int nt,DateTime tao,int bh,List<Item> items,int g)
        {
            HoaDon don = null;
            typeof(HoaDon).GetMethod("HoaDon",BindingFlags.Instance|
                BindingFlags.NonPublic).Invoke(don,new object[] {kh,nt,tao,bh,items,g});
            return don;
        }
        private void To_String()
        {
            System.Console.WriteLine(Username + " " + Password);
        }
        public User(User user)
        {
            this.Username = user.Username;
            this.Password = user.Password;
            this.dateCreate = user.dateCreate;
        }
        public bool verify(string u, string p)
        {
            return Username == u && Password == p;

        }

    }
    public class KhachHang
    {
        private int ID;
        private User user;
        private string Name;
        private string phone;
        private bool gender;
        private string address;
        private Image image;
        public KhachHang()
        {

        }
        public KhachHang(int id,string n,string address,string phone,bool gender, byte[] imageData)
        {
            this.ID = id;
            Name = n;this.address = address;
            this.phone = phone;
            this.gender = gender;
            image = Methods.ConvertBytesToImage(imageData);
        }
        public KhachHang(int id, string n, string address, string phone, bool gender, Image im)
        {
            this.ID = id;
            Name = n; this.address = address;
            this.phone = phone;
            this.gender = gender;
            image = im;

        }
        public string getName()
        {
            return Name;
        }
        public string getPhone()
        {
            return phone;
        }
        public bool isMan()
        {
            return gender;
        }
        public string getAddress()
        {
            return address;
        }
        public int getID()
        {
            return ID;
        }
        public void To_String()
        {
            Console.WriteLine("- Ten: "+Name);
            Console.WriteLine("- LichSu: " + user.layLichSu());
        }
        public Image getPortrait()
        {
            return image;
}
    }
}
