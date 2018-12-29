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

            filterModeItemsProd = new Dictionary<String, String>();
            filterModeItemsProd.Add("Mã sản phẩm", "Id");
            filterModeItemsProd.Add("Tên sản phẩm", "Name");


            cbbFilterMode.DataSource = new BindingSource(filterModeItemsProd, null);
            cbbFilterMode.DisplayMember = "Key";
            cbbFilterMode.ValueMember = "Value";

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
                animationTimer.Tick += materNewShowAnimation;
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
                Products currPro = proList.ProductList[dgvMainTable.SelectedRows[0].Index];
                lblEditID.Text = currPro.ID;
            }
        }
    }
}
