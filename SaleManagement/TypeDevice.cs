using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement
{
    public class TypeDevice
    {
        public readonly int IDType;
        public readonly string Type;
        public readonly string screen;
        public readonly String OS;
        public readonly String frontCamera;
        public readonly String backCamera;
        public readonly String chip;
        public readonly int Ram;
        public readonly int Capacity;
        public readonly int Battery;

        public readonly List<string> Appearances;
        public TypeDevice() { }
        public TypeDevice(TypeDevice typeDevice)
        {
            this.screen = typeDevice.screen;
            this.OS = typeDevice.OS;
            this.Ram = typeDevice.Ram;
            this.Capacity = typeDevice.Capacity;
            this.Battery = typeDevice.Battery;
            this.chip = typeDevice.chip;
            this.backCamera = typeDevice.backCamera;
            this.frontCamera = typeDevice.frontCamera;
            this.Appearances = typeDevice.Appearances;
        }
        /// <summary>
        /// Tao thiet bi
        /// </summary>
        /// <param name="size">kich thuoc man hinh</param>
        /// <param name="os">he dieu hanh (IOS, android)</param>
        /// <param name="font">camera truoc</param>
        /// <param name="back">camera sau</param>
        /// <param name="chip">chip</param>
        /// <param name="Ram">ram thiet bi</param>
        /// <param name="ca">dung luong thiet bi co duoc</param>
        /// <param name="bat">dung luong pin</param>
        /// <param name="port">danh sach anh thiet bi</param>
        public TypeDevice(string type,string size, string os, string font, string back, string chip, int Ram, int ca, int bat, List<string> port)
        {
            this.Type = type;
            this.screen = size;
            this.OS = os;
            this.frontCamera = font;
            this.backCamera = back;
            this.chip = chip;
            this.Battery = bat;
            this.Ram = Ram;
            this.Capacity = ca;
            this.Appearances = port;
        }

        public bool isEqual(TypeDevice D)
        {
            if (D.Appearances.Count != this.Appearances.Count) return false;
            for (int i = 0; i < Appearances.Count; i++)
            {
                if (this.Appearances[i] != D.Appearances[i])
                {
                    return false;
                }
            }
            return this.screen == D.screen && this.OS == D.OS && this.frontCamera == D.frontCamera
                && this.chip == D.chip && this.Ram == D.Ram && this.Capacity == D.Capacity && this.Battery == D.Battery;
        }
    }
    public class Item : TypeDevice
    {
        public int IDItem;
        public string Name;
        public string Description;
        public string promo;
        public float rating;
        public string price;
        public int discountPercentage;
        public int installmentPercentage;
        public string portrait;
        /// <summary>
        /// Tao san pham tren gian hang
        /// </summary>
        /// <param name="n">ten gian hang</param>
        /// <param name="d">mo ta gian hang</param>
        /// <param name="r">danh gia gian hang</param>
        /// <param name="p">gia gian hang</param>
        /// <param name="dis">giam gia</param>
        /// <param name="installment">bao hanh</param>
        /// <param name="type">Loai thiet bi</param>
        public Item(int iditem, string n,string promo, string d, float r, string p, int dis, int installment,string portrait, TypeDevice type) : base(type)
        {
            this.IDItem = iditem;
            this.Name = n;
            this.promo = promo;
            this.Description = d;
            this.rating = r;
            this.price = p;
            this.discountPercentage = dis;
            this.installmentPercentage = installment;
            this.portrait = portrait;

        }
        public bool isEqual(Item item)
        {

            return base.isEqual(item)&&this.IDItem==item.IDItem && this.Name == item.Name && this.Description == item.Description && this.rating == item.rating
                && this.price == item.price && this.discountPercentage == item.discountPercentage && this.installmentPercentage == item.installmentPercentage;

        }
    }
}
