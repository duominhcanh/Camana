using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Graphics
{
    public partial class frmSale : Form
    {

        public delegate void functioncall(Products pro);
        private event functioncall formFunctionPointer;
        private List<SaleProductListItem> listProd;

        private Entities.Lists.ProductsList proList;

        public frmSale()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            proList = new Entities.Lists.ProductsList();
            proList.loadFromDb();

            listProd = new List<SaleProductListItem>();

            foreach(Products pro in proList.ProductList)
            {
                listProd.Add(new SaleProductListItem(pro));
            }

            listProd.Add(new SaleProductListItem(new Products("P06", "Khô cá", 2000)));
            listProd.Add(new SaleProductListItem(new Products("P07", "Khô bò", 3000)));
            listProd.Add(new SaleProductListItem(new Products("P08", "Khô mỏ", 4000)));

            formFunctionPointer += new functioncall(showInfo);

            foreach (SaleProductListItem spl in listProd)
            {
                spl.userFunctionPointer = formFunctionPointer;
            }

            foreach (SaleProductListItem spl in listProd)
            {
                lsProducts.Controls.Add(spl);
            }            
        }

        private void showInfo(Products pro)
        {
            txtSelectedID.Text = pro.ID;
            txtSelectedName.Text = pro.Name;
            txtSelectedPrice.Text = pro.Price.ToString();
        }
    }
}
