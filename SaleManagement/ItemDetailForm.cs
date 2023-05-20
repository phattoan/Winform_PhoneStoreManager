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
    public partial class ItemDetailForm : Form
    {
        ItemPanel panel = new ItemPanel();
        public ItemDetailForm(Item item,List< string> promo, List<string> des,List<Item> litem)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            
            panel.initialization(item,promo,des,litem);
            panel.Dock = DockStyle.Fill;
            this.Size = panel.Size;this.Controls.Add(panel);
        }

        private void ItemDetailForm_SizeChanged(object sender, EventArgs e)
        {
            panel.Size = this.Size;
        }
    }
}
