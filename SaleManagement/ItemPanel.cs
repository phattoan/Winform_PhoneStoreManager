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
    public partial class ItemPanel : UserControl
    {
        public ItemPanel()
        {
            InitializeComponent();
           
        }
        List<Item> items;
        Item gItem;
        public void initialization(Item item,List< string> promotions, List<string> description,List<Item> litems)
        {
            Image[] images = new Image[item.Appearances.Count];
            items = litems;
            gItem = item;
            for(int i=0;i<images.Length; i++)
            {
                images[i] = Methods.gatherData_Url(item.Appearances[i]);
            }
            //Initialize and adjust size and positions
            imageSlideShow1.initialization(images);
            namelbl.Text = item.Name;
            panel1.Top = namelbl.Bottom;
            panel1.Left = namelbl.Left;
            promogroup.Left = imageSlideShow1.Right + 20;
            button1.Top = promogroup.Bottom + 20;
            thongsogroup.Top = button1.Bottom+20 ;
            thongsogroup.Left = promogroup.Left;
            thongtingroup.Top = imageSlideShow1.Bottom + 20;
            thongtingroup.Left = imageSlideShow1.Left;
            thongsogroup.Left = thongtingroup.Right + 20;
            thongsogroup.Top = thongtingroup.Top;
            reScalePanel();
            foreach(var ob in litems)
            {
                if(item.isEqual(ob))
                {
                    isPressed = true;
                    button1.Text = "Hủy thêm vào danh sách";
                    button1.ForeColor = Color.Black;
                    button1.BackColor = Color.White;
                    break;
                }
            }
            string temp = "";
            foreach(var ob in promotions)
            {
                temp +="- "+ ob+"\n";
            }
            promotextbox.Text =temp.Replace('|','\n');
            foreach (var ob in description)
            {
                thongtintextbox.Text +="- "+ob+"\n";
            }
            thongtintextbox.ReadOnly = true;
            promotextbox.ReadOnly = true;
            promogroup.Text = item.price;
            manhinhlbl.Text = item.screen;
            OSlbl.Text = item.OS;
            cameratruoclbl.Text = item.frontCamera;
            camerasaulbl.Text = item.backCamera;
            chiplbl.Text = item.chip;
            ramlbl.Text = item.Ram.ToString()+" GB";
            dungluonglbl.Text = item.Capacity.ToString()+" GB";
            pinlbl.Text = item.Battery.ToString() + " mAh";
        }
        private void reScalePanel()
        {
            imageSlideShow1.Top = titlepanel.Bottom + 20;
            imageSlideShow1.Left = titlepanel.Left;
            promogroup.Width = this.Width - imageSlideShow1.Right - 60;
            //promogroup.Left =imageSlideShow1.Right+ ((this.Width -imageSlideShow1.Right)/2)-(promogroup.Width/2)-15;
            promogroup.Top = imageSlideShow1.Top;
            thongsogroup.Left = this.Right - thongsogroup.Width - 30;
            thongtingroup.Width= thongsogroup.Left-20;
            thongsogroup.Top = thongtingroup.Top ;
            thongtingroup.Height = this.Bottom - thongtingroup.Top - 10;
        }

        private void ItemPanel_SizeChanged(object sender, EventArgs e)
        {
            reScalePanel();
        }
        bool isPressed = false;
        private void button1_Click(object sender, EventArgs e)
        {
               try
            {
                if(isPressed)
                {
                    foreach(var ob in items)
                    {
                        if(ob.isEqual(gItem))
                        {
                            items.Remove(ob);
                            isPressed = false;
                            button1.ForeColor = Color.White;
                            button1.BackColor = Color.Coral;
                            button1.Text = "Thêm vào danh sách";
                            return;
                        }    
                    }
                    isPressed = false;
                    button1.ForeColor = Color.White;
                    button1.BackColor = Color.Coral;
                    MessageBox.Show("Sản phẩm không tồn tại trong danh sách");
                    return;
                    
                }
                else
                {
                    foreach (var ob in items)
                    {
                        if (ob.isEqual(gItem))
                        {
                            MessageBox.Show("Sản phẩm đã tồn tại trong danh sách!");
                            return;
                        }
                    }
                    items.Add(gItem);
                    isPressed = true;
                    button1.Text = "Hủy thêm vào danh sách";
                    button1.ForeColor = Color.Black;
                    button1.BackColor = Color.White;
                }
            }catch(Exception)
            {

            }

                
        }
    }
}
