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
    public partial class ComboButton : UserControl
    {
        public bool[] list;
        public int count=0;
        public ComboButton(int row,int colum,Control[] controls, Padding padding)
        {
            InitializeComponent();
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            list=new bool[controls.Length];
            int size = 0;
            for(int i=0;i<colum;i++)
            {
                size += controls[i].Width;
            }
            this.Width = size+(padding.Right * colum) + 8;
            this.Height = controls[0].Height * row+ (padding.Bottom * row)+5;
            int c = 0;
            while (c<controls.Length)
            {
                list[c] = false;
                flowLayoutPanel1.Controls.Add(controls[c]);
                controls[c].Click += button_Click;
                c++;
            }
            this.controls = controls;
            
        }
        Control[] controls;
        private void button_Click(object sender, EventArgs e)
        {
            Button con = ((Button)sender);
            string filtername = con.Text;
            con.FlatStyle = (con.FlatStyle==FlatStyle.System) ?FlatStyle.Flat:FlatStyle.System;
            for(int i=0;i<controls.Length;i++)
            {
                if (con == (Button)controls[i])
                {
                    if (list[i]) count--;
                    else count++;
                    list[i] = !list[i];
                }
            }
            
        }
        private void flowLayoutPanel1_Leave(object sender, EventArgs e)
        {
            
            this.Visible = false;
        }
    }
}
