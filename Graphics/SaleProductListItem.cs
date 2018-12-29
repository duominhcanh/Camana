using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Graphics
{
    public partial class SaleProductListItem : UserControl
    {
        private Products pro;

        public Delegate userFunctionPointer;

        public SaleProductListItem()
        {
            InitializeComponent();
        }

        public SaleProductListItem(Products pro)
        {
            InitializeComponent();
            this.Pro = pro;

            lblID.Text = this.Pro.ID;
            lblName.Text = this.Pro.Name;
            lblPrice.Text = this.Pro.Price.ToString();
        }

        public Products Pro { get => pro; set => pro = value; }

        private void Clicked(object sender, EventArgs e)
        {
            userFunctionPointer.DynamicInvoke(this.Pro);
        }

        private void SaleProductListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(120, 224, 143);
        }

        private void SaleProductListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
