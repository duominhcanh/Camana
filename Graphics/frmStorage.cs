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
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace Graphics
{
    public partial class frmStorage : Form
    {
        private int mode;
        private Entities.Lists.ProductsList proList;
        private Entities.Lists.MaterialsList materList;
        private Timer animationTimer;
        private Dictionary<String, String> filterModeItemsMater;
        private Dictionary<String, String> filterModeItemsProd;


        public frmStorage()
        {
            InitializeComponent();

            animationTimer = new Timer();
            animationTimer.Interval = 10;
            animationTimer.Start();

            //Chọn mode mặc định
            mode = 1;
            proList = new Entities.Lists.ProductsList();
            materList = new Entities.Lists.MaterialsList();
            proList.loadFromDb();
            materList.loadFromDb();
            dgvMainTable.DataSource = proList.ProductList;
            lblTitle.Text = "Kho- Sản phẩm";


            this.MaximizeBox = false;

            pnlLeftInfo.Location = new Point(-pnlLeftInfo.Width, 81);
            pnlAddPro.Location = new Point(-pnlAddPro.Width, 81);
            pnlNewResource.Location = new Point(-pnlNewResource.Width, 81);
            pnlResourceInfo.Location = new Point(-pnlResourceInfo.Width, 81);

            pnlEditAction.Visible = false;
            pnlLeftInfo.BringToFront();
            dgvMainTable.MultiSelect = false;


            filterModeItemsMater = new Dictionary<String, String>();
            filterModeItemsMater.Add("Mã nguyên liệu", "Id");
            filterModeItemsMater.Add("Tên nguyên liệu", "Name");
            filterModeItemsMater.Add("Nhà cung cấp ", "Supplier");
            filterModeItemsMater.Add("Số lượng", "Ammount");


            filterModeItemsProd = new Dictionary<String, String>();
            filterModeItemsProd.Add("Mã sản phẩm", "Id");
            filterModeItemsProd.Add("Tên sản phẩm", "Name");


            cbbFilterMode.DataSource = new BindingSource(filterModeItemsProd, null);
            cbbFilterMode.DisplayMember = "Key";
            cbbFilterMode.ValueMember = "Value";

        }

        private void fillProduct()
        {
            if (dgvMainTable.SelectedRows.Count > 0)
            {
                Products current = proList.ProductList[dgvMainTable.SelectedRows[0].Index];

                lblEditID.Text = current.ID;
                txtEditName.Text = current.Name;
                txtEditPrice.Text =current.Price.ToString();                       
            }
        }

        private void fillEnterials()
        {
            if (dgvMainTable.SelectedRows.Count > 0)
            {
                Materials current1 = materList.MaterList[dgvMainTable.SelectedRows[0].Index];

                lblEdit_ID_Mater.Text = current1.Id;
                txtNameMarter.Text = current1.Name;
                txtAmount_Marter.Text = current1.Ammount.ToString();
                txtSupplier_Mar.Text = current1.Supplier;
            }
        }

        private void empMoreInfoAnimation(Object tsender, EventArgs te)
        {
            if (pnlLeftInfo.Location.X >= pnlLeft.Location.X)
            {
                if (pnlLeftInfo.Location.X > pnlLeft.Location.X)
                {
                    pnlLeftInfo.Location = pnlLeft.Location;
                }
                animationTimer.Tick -= empMoreInfoAnimation;
            }
            else
            {
                pnlLeftInfo.Location = new Point(pnlLeftInfo.Location.X + 10, 81);
            }
        }

        private void empLessInfoAnimation(Object tsender, EventArgs te)
        {
            if (pnlLeftInfo.Location.X <= -pnlLeftInfo.Width)
            {
                if (pnlLeftInfo.Location.X < -pnlLeftInfo.Width)
                {
                    pnlLeftInfo.Location = new Point(-pnlLeftInfo.Width, 81);
                }
                animationTimer.Tick -= empLessInfoAnimation;
            }
            else
            {
                pnlLeftInfo.Location = new Point(pnlLeftInfo.Location.X - 10, 81);
            }
        }

        private void proNewShowAnimation(Object tsender, EventArgs te)
        {
            if (pnlAddPro.Location.X >= pnlLeft.Location.X)
            {
                if (pnlAddPro.Location.X > pnlLeft.Location.X)
                {
                    pnlAddPro.Location = pnlLeft.Location;
                }
                animationTimer.Tick -= proNewShowAnimation;
            }
            else
            {
                pnlAddPro.Location = new Point(pnlAddPro.Location.X + 10, 81);
            }
        }

        private void proNewHideAnimation(Object tsender, EventArgs te)
        {
            if (pnlAddPro.Location.X <= -pnlAddPro.Width)
            {
                if (pnlAddPro.Location.X < -pnlAddPro.Width)
                {
                    pnlAddPro.Location = new Point(-pnlAddPro.Width, 81);
                }
                animationTimer.Tick -= proNewHideAnimation;
            }
            else
            {
                pnlAddPro.Location = new Point(pnlAddPro.Location.X - 10, 81);
            }
        }

        private void updateGridView_Product(DataGridView thisGridView, List<Products> source)
        {
            thisGridView.DataSource = null;
            thisGridView.Refresh();
            thisGridView.Update();
            thisGridView.DataSource = source;
        }

        private void updateGridView_Materials(DataGridView thisGridView, List<Materials> source)
        {
            thisGridView.DataSource = null;
            thisGridView.Refresh();
            thisGridView.Update();
            thisGridView.DataSource = source;
        }

        //=======New Material Animation================
        private void materMoreInfoAnimation(Object tsender, EventArgs te)
        {
            if (pnlResourceInfo.Location.X >= pnlLeft.Location.X)
            {
                if (pnlResourceInfo.Location.X > pnlLeft.Location.X)
                {
                    pnlResourceInfo.Location = pnlLeft.Location;
                }
                animationTimer.Tick -= materMoreInfoAnimation;
            }
            else
            {
                pnlResourceInfo.Location = new Point(pnlResourceInfo.Location.X + 10, 81);
            }
        }

        private void materLessInfoAnimation(Object tsender, EventArgs te)
        {
            if (pnlResourceInfo.Location.X <= -pnlLeftInfo.Width)
            {
                if (pnlResourceInfo.Location.X < -pnlLeftInfo.Width)
                {
                    pnlResourceInfo.Location = new Point(-pnlResourceInfo.Width, 81);
                }
                animationTimer.Tick -= materLessInfoAnimation;
            }
            else
            {
                pnlResourceInfo.Location = new Point(pnlResourceInfo.Location.X - 10, 81);
            }
        }

        private void materNewShowAnimation(Object tsender, EventArgs te)
        {
            if (pnlNewResource.Location.X >= pnlLeft.Location.X)
            {
                if (pnlNewResource.Location.X > pnlLeft.Location.X)
                {
                    pnlNewResource.Location = pnlLeft.Location;
                }
                animationTimer.Tick -= materNewShowAnimation;
            }
            else
            {
                pnlNewResource.Location = new Point(pnlNewResource.Location.X + 10, 81);
            }
        }

        private void materNewHideAnimation(Object tsender, EventArgs te)
        {
            if (pnlNewResource.Location.X <= -pnlNewResource.Width)
            {
                if (pnlNewResource.Location.X < -pnlNewResource.Width)
                {
                    pnlNewResource.Location = new Point(-pnlNewResource.Width, 81);
                }
                animationTimer.Tick -= materNewHideAnimation;
            }
            else
            {
                pnlNewResource.Location = new Point(pnlNewResource.Location.X - 10, 81);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(mode == 1)
            {
                pnlAddPro.BringToFront();
                animationTimer.Tick += proNewShowAnimation;
            }
            else if(mode == 2)
            {
                pnlNewResource.BringToFront();
                animationTimer.Tick += materNewShowAnimation;
            }

        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            if(mode == 1)
            {
                pnlLeftInfo.BringToFront();
                animationTimer.Tick += empMoreInfoAnimation;
                if(dgvMainTable.SelectedRows.Count > 0)
                {
                    Products currPro = proList.ProductList[dgvMainTable.SelectedRows[0].Index];
                    lblEditID.Text = currPro.ID;
                }
            }
            else if(mode == 2)
            {
                pnlResourceInfo.BringToFront();
                animationTimer.Tick += materMoreInfoAnimation;
            }
        }

        private void btnEditClose_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += empLessInfoAnimation;
        }

        private void btnAddEmpClose_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += proNewHideAnimation;
        }

        private void btnMode1_Click(object sender, EventArgs e)
        {
            this.mode = 1;
            lblTitle.Text = "Kho- Sản phẩm";
            dgvMainTable.DataSource = proList.ProductList;
            cbbFilterMode.DataSource = new BindingSource(filterModeItemsProd, null);
            cbbFilterMode.DisplayMember = "Key";
            cbbFilterMode.ValueMember = "Value";
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            this.mode = 2;
            lblTitle.Text = "Kho- Nguyên liệu";
            dgvMainTable.DataSource = materList.MaterList;
            cbbFilterMode.DataSource = new BindingSource(filterModeItemsMater, null);
            cbbFilterMode.DisplayMember = "Key";
            cbbFilterMode.ValueMember = "Value";
        }

        private void btnMaterInfoClose_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += materLessInfoAnimation;
        }

        private void btnMaterNewClose_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += materNewHideAnimation;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvMainTable.DataSource = null;
            dgvMainTable.Update();
            if(mode == 1)
            {
                proList.loadFromDb();
                dgvMainTable.DataSource = proList.ProductList;
            }
            else if(mode == 2)
            {
                materList.loadFromDb();
                dgvMainTable.DataSource = materList.MaterList;
            }
            dgvMainTable.Refresh();
        }

        private void dgvMainTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMainTable.SelectedRows.Count > 0)
            {
                if(mode == 1)
                {
                    Products currPro = proList.ProductList[dgvMainTable.SelectedRows[0].Index];
                    lblEditID.Text = currPro.ID;
                    fillProduct();
                }
                else if(mode == 2)
                {
                    Materials currPro = materList.MaterList[dgvMainTable.SelectedRows[0].Index];
                    lblEditID.Text = currPro.Id;
                    fillEnterials();
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            String newID = txtNewID.Text;
            String newName = txtNewName.Text;
            double newPrice = Double.Parse(txtNewPrice.Text);          
            Products newPro = new Products(newID,newName,newPrice);

            proList.add(newPro);
            updateGridView_Product(dgvMainTable, proList.ProductList);
            txtNewID.Text = txtNewName.Text = txtNewPrice.Text = "";
            txtNewID.Focus();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            String newID = txtID.Text;
            String newName = txtName.Text;
            int newAmount = Int32.Parse(txtAmount.Text);
            String newsupplier = txtSupplier.Text;          
            Materials newMater = new Materials(newID, newName, newAmount,newsupplier);

            materList.add(newMater);
            updateGridView_Materials(dgvMainTable, materList.MaterList);
            txtID.Text = txtName.Text = txtAmount.Text = txtSupplier.Text= "";
            txtID.Focus();
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            String message = "Chắc chắn muốn xóa sản phẩm này! ?";
            if (MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                proList.remove(lblEditID.Text);
                updateGridView_Product(dgvMainTable, proList.ProductList);
            }
            else { return; }

            if (dgvMainTable.RowCount == 0)
            {
                animationTimer.Tick += empLessInfoAnimation;
            }
            pnlEditAction.Visible = false;
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            fillProduct();
            pnlEditAction.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillEnterials();
            pnlEditAction.Visible = false;
        }

        private void btnEditAccept_Click(object sender, EventArgs e)
        {
            Products currentpro = proList.find(lblEditID.Text);
            currentpro.Name = txtEditName.Text;
            currentpro.Price = Double.Parse(txtEditPrice.Text);          
            updateGridView_Product(dgvMainTable, proList.ProductList);
            pnlEditAction.Visible = false;
        }

        private void btnEditAccept_Materials_Click(object sender, EventArgs e)
        {
            Materials currentmater = materList.find(lblEdit_ID_Mater.Text);
            currentmater.Name = txtNameMarter.Text;
            currentmater.Ammount = Double.Parse(txtAmount_Marter.Text);
            currentmater.Supplier = txtSupplier.Text;
            updateGridView_Materials(dgvMainTable, materList.MaterList);
            pnlEditAction.Visible = false;
        }

        private void btnEditPrevProd_Click(object sender, EventArgs e)
        {
            if (dgvMainTable.SelectedRows[0].Index == dgvMainTable.RowCount - 1)
            {
                dgvMainTable.Rows[0].Selected = true;

            }
            else
            {
                dgvMainTable.Rows[dgvMainTable.SelectedRows[0].Index - 1].Selected = true;
            }
            txtName.Focus();
            pnlEditAction.Visible = false;
        }

        private void btnEditNextProd_Click(object sender, EventArgs e)
        {
            if (dgvMainTable.SelectedRows[0].Index == dgvMainTable.RowCount - 1)
            {
                dgvMainTable.Rows[0].Selected = true;

            }
            else
            {
                dgvMainTable.Rows[dgvMainTable.SelectedRows[0].Index + 1].Selected = true;
            }
            txtName.Focus();
            pnlEditAction.Visible = false;
        }

        private void btnEditPrevMater_Click(object sender, EventArgs e)
        {
            if (dgvMainTable.SelectedRows[0].Index == dgvMainTable.RowCount - 1)
            {
                dgvMainTable.Rows[0].Selected = true;

            }
            else
            {
                dgvMainTable.Rows[dgvMainTable.SelectedRows[0].Index - 1].Selected = true;
            }
            txtName.Focus();
            pnlEditAction.Visible = false;
        }

        private void btnEditNextMater_Click(object sender, EventArgs e)
        {
            if (dgvMainTable.SelectedRows[0].Index == dgvMainTable.RowCount - 1)
            {
                dgvMainTable.Rows[0].Selected = true;

            }
            else
            {
                dgvMainTable.Rows[dgvMainTable.SelectedRows[0].Index + 1].Selected = true;
            }
            txtName.Focus();
            pnlEditAction.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(mode == 1)
            {
                proList.saveChanges();
                MessageBox.Show("Đã lưu thay đổi vào csdl");
            }

            // cho xet mode 2
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if(mode == 1)
            {
                updateGridView_Product(dgvMainTable, proList.filter(txtFilter.Text, cbbFilterMode.SelectedValue.ToString()));
            }
            else if(mode == 2)
            {
                updateGridView_Materials(dgvMainTable, materList.filter(txtFilter.Text, cbbFilterMode.SelectedValue.ToString()));
            }
        }
    }

}
