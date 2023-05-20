using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public static class Methods
    {
        static public byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms=new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        static public Image ConvertBytesToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        public static Image resize_BitMap(Image image, Size size)
        {
            Bitmap res = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(res))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                g.DrawImage(image, 0, 0, size.Width, size.Height);
            }
            return res;
        }
        public static Bitmap resize_BitMap(Image image,int w, int h )
        {
            Bitmap res = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(res))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                g.DrawImage(image, 0, 0, w, h);
            }
            return res;
        }
        static public Image ScaleImageToFit(Image originalImage, int maxWidth, int maxHeight)
        {
            int newWidth, newHeight;

            // Calculate the new dimensions while preserving the aspect ratio
            if (originalImage.Width > originalImage.Height)
            {
                newWidth = maxWidth;
                newHeight = (int)(((double)originalImage.Height / originalImage.Width) * maxWidth);
            }
            else
            {
                newHeight = maxHeight;
                newWidth = (int)(((double)originalImage.Width / originalImage.Height) * maxHeight);
            }

            // Create a thumbnail image with the calculated dimensions
            Image scaledImage = originalImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);

            return scaledImage;
        }
        public static Image gatherData_Url(string add)
        {
            WebClient web = new WebClient();
            byte[] bytes = web.DownloadData(add);
            MemoryStream ms = new MemoryStream(bytes);
            Image image = Image.FromStream(ms);
            return image;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
    }
    public class OvalPictureBox : PictureBox
    {
        public OvalPictureBox()
        {
            this.BackColor = Color.DarkGray;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }
    }
}
