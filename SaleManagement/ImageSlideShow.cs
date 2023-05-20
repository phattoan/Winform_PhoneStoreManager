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
    public partial class ImageSlideShow : UserControl
    {
        Image[] images;
        Timer timer = new Timer();
        Timer transistion = new Timer();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        Size s;
        public ImageSlideShow(Image[] images, Size size)
        {
            InitializeComponent();
            this.images = images; s = size;
            loadImages();
            this.panel1.Size = s;
            preBtn.Height = s.Height;
            nextBtn.Height = s.Height;
            nextBtn.Size = new Size(s.Height / 10, s.Width / 10);
            nextBtn.Image=Methods.resize_BitMap(nextBtn.Image,nextBtn.Size);
            preBtn.Size = new Size(s.Height / 10, s.Width / 10);
            preBtn.Image = Methods.resize_BitMap(preBtn.Image, preBtn.Size);
            
            preBtn.BringToFront();
            nextBtn.BringToFront();
            this.panel1.Controls.Add(slidePanel);
            this.panel1.Location = new Point(0, 0);
            slidePanel.Left = this.panel1.Left;
            slidePanel.Top = 0;
            this.Size = panel1.Size;
            nextBtn.Location = new Point(this.panel1.Right - nextBtn.Width, this.panel1.Bottom / 2 - (this.nextBtn.Height / 2));
            preBtn.Location = new Point(this.panel1.Left, this.panel1.Bottom / 2 - (this.preBtn.Height / 2));
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            transistion.Interval = 1;
            transistion.Tick += Transistion_TickLeft;

            timer.Enabled = true;
        }
        int stoppoint;
        private bool slideRight(int border, Control c)
        {
            c.Left += 10;
            if (c.Left >= border)
            {
                c.Left = border;
                return true;
            }
            return false;
        }
        private bool slideLeft(int border, Control c)
        {
            c.Left -= 10;
            if(c.Left<=border)
            {
                c.Left = border;
                return true;
            }
            return false;
        }
        int orderShow = 0;
        bool isReverse = false;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(transistion.Enabled==false)
            {
                if (isReverse)
                {
                    transistion.Tick += Transistion_TickRight;
                }
                else
                {
                    transistion.Tick += Transistion_TickLeft;
                }
            }
            if(isReverse)
            {
                stoppoint = slidePanel.Left + s.Width;
                orderShow--;
            }else
            {
                stoppoint = slidePanel.Left - s.Width;
                orderShow++;
            }
            transistion.Start();

        }

        private void Transistion_TickLeft(object sender, EventArgs e)
        {
            if (slideLeft(stoppoint, slidePanel))
            {
                transistion.Stop();
                transistion = new Timer() { Interval=1};
                if(orderShow==images.Length-1)
                {
                    isReverse = true;
                }
            }
        }

        private void Transistion_TickRight(object sender, EventArgs e)
        {
            if(slideRight(stoppoint,slidePanel))
            {
                transistion.Stop();
                transistion = new Timer() { Interval=1};
                if (orderShow == 0)
                {
                    isReverse = false;
                }
            }
        }

        private void loadImages()
        {
            Image[] image = new Image[images.Length];
            for (int i = 0; i < images.Length; i++)
            {
                image[i] = Methods.resize_BitMap(images[i], s);
                
            }
            PictureBox pre = new PictureBox() { Size = new Size(0, 0) };
            slidePanel.Size = new Size(0, s.Height);
            for (int i = 0; i < images.Length; i++)
            {
                PictureBox picture = new PictureBox() { Size = image[i].Size, Image = image[i] };
                picture.Click += picture_Click;
                picture.Left = pre.Right;
                slidePanel.Width += picture.Width;
                slidePanel.Controls.Add(picture);
                pictureBoxes.Add(picture);
                pre = picture;
            }
        }
        private void picture_Click(object sender,EventArgs e)
        {
           var pic= (PictureBox)sender;
            int i = 0;
            while (pic != pictureBoxes[i])
            {
                i++;
            }
            new ImageForm(images[i]).Show();
            
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (transistion.Enabled == false&&orderShow<images.Length-1)
            {
                timer.Stop();
                isReverse = false;
                Timer_Tick(sender, e);
                timer.Start();
            }

        }

        private void preBtn_Click(object sender, EventArgs e)
        {
            if (transistion.Enabled == false&&orderShow>0)
            {
                timer.Stop();
                isReverse = true;
                Timer_Tick(sender, e);
                timer.Start();
            }
        }
    }
}
