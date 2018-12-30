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
    public partial class frmBillsManager : Form
    {

        private Entities.Lists.BillsList bllList = new Entities.Lists.BillsList();
        private Dictionary<String, String> filterModeItems;

        private Bills currBill;

        public frmBillsManager()
        {
            InitializeComponent();

            bllList.loadFromDb();

            dgvBillList.DataSource= new BindingSource(bllList.BillList, null);
            dgvBillList.MultiSelect = false;

            dgvBill.Columns.Add("ID", "Mã");
            dgvBill.Columns.Add("Name", "Tên");
            dgvBill.Columns.Add("Count", "Số Lượng");
            dgvBill.Columns.Add("Price", "Đơn giá");
            dgvBill.Columns.Add("Sum", "Thành tiền");

            dgvBill.Columns[0].Width = 50;
            dgvBill.Columns[2].Width = 40;
            dgvBill.MultiSelect = false;

            filterModeItems = new Dictionary<String, String>();
            filterModeItems.Add("Mã hóa đơn", "Id");
            filterModeItems.Add("Mã Nhân viên", "Emp_id");
            filterModeItems.Add("Ngày lập", "DayCreated");

            cbbFilterMode.DataSource = new BindingSource(filterModeItems, null);
            cbbFilterMode.DisplayMember = "Key";
            cbbFilterMode.ValueMember = "Value";

            this.MaximizeBox = false;

        }

        private void dgvBillList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBillList.SelectedRows.Count != 0)
            {
                currBill = bllList.find(dgvBillList.SelectedRows[0].Cells[0].Value.ToString());
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

                double sum = 0;

                foreach (KeyValuePair<Products, int> item in currBill.Products)
                {
                    dgvBill.Rows.Add(item.Key.ID, item.Key.Name, item.Value, item.Key.Price, item.Key.Price * item.Value);
                    sum += item.Key.Price * item.Value;
                }
                lblDateTime.Text = currBill.Date_created.ToShortDateString() + "  -  " + currBill.Date_created.ToShortTimeString();
                lblSumAll.Text = sum.ToString();
                txtBillID.Text = currBill.Id;
                lblEmpInfo.Text = currBill.Emp_id + "  -  " + currBill.getEmpName();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if(txtFilter.Text == "")
            {
                dgvBillList.DataSource = new BindingSource(bllList.BillList, null);
            }
            else
            {
                dgvBillList.DataSource = new BindingSource(bllList.filter(txtFilter.Text, cbbFilterMode.SelectedValue.ToString()), null);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
            {
                dgvBillList.DataSource = new BindingSource(bllList.BillList, null);
            }
            else
            {
                dgvBillList.DataSource = new BindingSource(bllList.filter(txtFilter.Text, cbbFilterMode.SelectedValue.ToString()), null);
            }
        }
    }
}
