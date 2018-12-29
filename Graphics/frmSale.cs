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
        private List<SaleProductListItem> listProdItem;
        private KeyValuePair<Products, int> selectedItem;
        private Entities.Lists.ProductsList proList;

        private Bills currBill= null;
        private double currSum = 0;

        public frmSale()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            proList = new Entities.Lists.ProductsList();
            proList.loadFromDb();
            formFunctionPointer += new functioncall(showInfo);

            listProdItem = new List<SaleProductListItem>();


            foreach(Products item in proList.ProductList) listProdItem.Add(new SaleProductListItem(item));

            foreach (SaleProductListItem sli in listProdItem)
            {
                sli.userFunctionPointer = formFunctionPointer;
                lsProducts.Controls.Add(sli);
            }

            txtAmmount.ReadOnly = true;
            pnlCount.Enabled = false;
            pnlProAction.Enabled = false;

            dgvBill.Columns.Add("ID", "Mã");
            dgvBill.Columns.Add("Name", "Tên");
            dgvBill.Columns.Add("Count", "Số Lượng");
            dgvBill.Columns.Add("Price", "Đơn giá");
            dgvBill.Columns.Add("Sum", "Thành tiền");

            dgvBill.Columns[0].Width = 50;
            dgvBill.Columns[2].Width = 40;
            dgvBill.MultiSelect = false;

            pnlItemEdit.Visible = false;
        }

        private void showInfo(Products pro)
        {
            lsProducts.Enabled = false;
            pnlCount.Enabled = true;
            pnlProAction.Enabled = true;
            selectedItem = new KeyValuePair<Products, int>(pro, 1);
            pnlPay.Enabled = false;

            txtSelectedID.Text = pro.ID;
            txtSelectedName.Text = pro.Name;
            txtSelectedPrice.Text = pro.Price.ToString();

            lblSum.Text = (selectedItem.Value* selectedItem.Key.Price).ToString();

            txtAmmount.Text = selectedItem.Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(selectedItem.Value == Int32.MaxValue - 1)
            {
                return;
            }
            selectedItem = new KeyValuePair<Products, int>(selectedItem.Key, selectedItem.Value + 1);
            txtAmmount.Text = selectedItem.Value.ToString();
            lblSum.Text = (selectedItem.Value * selectedItem.Key.Price).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            if(selectedItem.Value == 1)
            {
                return;
            }

            selectedItem = new KeyValuePair<Products, int>(selectedItem.Key, selectedItem.Value - 1);
            txtAmmount.Text = selectedItem.Value.ToString();
            lblSum.Text = (selectedItem.Value * selectedItem.Key.Price).ToString();

        }

        private void btnProRemove_Click(object sender, EventArgs e)
        {
            selectedItem = new KeyValuePair<Products, int>();
            lsProducts.Enabled = true;
            pnlCount.Enabled = false;
            pnlProAction.Enabled = false;
            txtSelectedID.Text = txtSelectedName.Text = txtSelectedPrice.Text = "";
            txtAmmount.Text = "";
            lblSum.Text = "";
            pnlPay.Enabled = true;

            if(currBill == null)
            {
                return;
            }
            updateDaBill();
        }

        private void btnProAdd_Click(object sender, EventArgs e)
        {
            currSum += selectedItem.Key.Price * selectedItem.Value;
            if (currBill == null)
            {
                currBill = new Bills("01", "E01", DateTime.Now);
                currBill.add_product(selectedItem.Key, selectedItem.Value);
                lblDateTime.Text = currBill.Date_created.ToShortTimeString() + " - " + currBill.Date_created.ToShortDateString();
            }
            else
            {
                currBill.add_product(selectedItem.Key, selectedItem.Value);
            }

            selectedItem = new KeyValuePair<Products, int>();
            lsProducts.Enabled = true;
            pnlCount.Enabled = false;
            pnlProAction.Enabled = false;
            txtSelectedID.Text = txtSelectedName.Text = txtSelectedPrice.Text = "";
            txtAmmount.Text = "";
            lblSum.Text = "";
            pnlPay.Enabled = true;

            updateDaBill();
        }

        private void updateDaBill()
        {
            if(currBill!= null)
            {
                do
                {
                    foreach (DataGridViewRow row in dgvBill.Rows)
                    {
                        try
                        {
                            dgvBill.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (dgvBill.Rows.Count > 1);

                foreach (KeyValuePair<Products, int> item in currBill.Products)
                {
                    dgvBill.Rows.Add(item.Key.ID, item.Key.Name, item.Value, item.Key.Price, item.Key.Price * item.Value);
                }
                lblSumAll.Text = currSum.ToString();
            }
            else
            {
                do
                {
                    foreach (DataGridViewRow row in dgvBill.Rows)
                    {
                        try
                        {
                            dgvBill.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (dgvBill.Rows.Count > 1);
            }
        }

        private void filtarDaList()
        {
            if(txtFilter.Text == "")
            {
                foreach (SaleProductListItem sli in listProdItem)
                {
                    lsProducts.Controls.Add(sli);
                }
                return;
            }
            lsProducts.Controls.Clear();
            foreach (SaleProductListItem sli in listProdItem)
            {
                if (sli.Pro.Name.ToLower().Contains(txtFilter.Text.ToLower()))
                {
                    lsProducts.Controls.Add(sli);
                }
            }
        }

        private void dgvBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvBill.SelectedRows[0].Cells[0].Value != null)
            {
                selectedItem = currBill.find(dgvBill.SelectedRows[0].Cells[0].Value.ToString());

                txtSelectedID.Text = selectedItem.Key.ID;
                txtSelectedName.Text = selectedItem.Key.Name;
                txtSelectedPrice.Text = selectedItem.Key.Price.ToString();
                lblSum.Text = (selectedItem.Key.Price * selectedItem.Value).ToString();
                txtAmmount.Text = selectedItem.Value.ToString();


                lsProducts.Enabled = false;
                pnlPay.Enabled = false;
                btnFindBill.Enabled = false;

                pnlItemEdit.Visible = true;
                pnlCount.Enabled = true;
                pnlProAction.Enabled = false;
            }
            else
            {
                itemEditControlsState();
            }

        }

        private void btnEditOut_Click(object sender, EventArgs e)
        {
            currBill.Products.Remove(selectedItem.Key);
            updateDaBill();
            itemEditControlsState();
        }

        private void btnEditOK_Click(object sender, EventArgs e)
        {
            currBill.Products[selectedItem.Key] = Int32.Parse(txtAmmount.Text);
            updateDaBill();
            itemEditControlsState();
        }

        private void btnEditContinue_Click(object sender, EventArgs e)
        {
            itemEditControlsState();
        }

        private void itemEditControlsState()
        {
            txtSelectedID.Text = txtSelectedName.Text = txtSelectedPrice.Text = lblSum.Text = "";

            lsProducts.Enabled = true;
            pnlPay.Enabled = true;
            btnFindBill.Enabled = true;

            pnlProAction.Enabled = false;
            pnlItemEdit.Visible = false;
            pnlCount.Enabled = false;
        }

        private void btnBillCancel_Click(object sender, EventArgs e)
        {
            currBill = null;
            updateDaBill();
        }

        private void btnBillPay_Click(object sender, EventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            filtarDaList();
        }
    }
}
