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
    public partial class frmEmployees : Form
    {
        private Entities.Lists.EmployeesList empList;
        private Timer animationTimer;
        private Dictionary<String, String> filterModeItems;

        public frmEmployees()
        {
            InitializeComponent();
            animationTimer = new Timer();
            animationTimer.Interval = 10;
            animationTimer.Start();

            empList = new Entities.Lists.EmployeesList();
            empList.loadFromDb();

            this.MaximizeBox = false;
            updateGridView(dgvEmployeesTable, empList.EmpList);
            dgvEmployeesTable.MultiSelect = false;
            pnlLeftInfo.Location = new Point(-pnlLeftInfo.Width, 81);
            pnlAddEmp.Location = new Point(-pnlAddEmp.Width, 81);

            pnlEditAction.Visible = false;

            filterModeItems = new Dictionary<String, String>();
            filterModeItems.Add("Mã nhân viên", "Id");
            filterModeItems.Add("Tên nhân viên", "Name");
            filterModeItems.Add("Chức vụ", "Role");
            filterModeItems.Add("Số điện thoại", "Phone");
            filterModeItems.Add("Giới tính", "Sex");
            filterModeItems.Add("Ngày sinh", "Birth");
            filterModeItems.Add("Ngày nhận việc", "DayIn");
            filterModeItems.Add("Địa chỉ", "Address");

            cbbFilterMode.DataSource = new BindingSource(filterModeItems, null);
            cbbFilterMode.DisplayMember = "Key";
            cbbFilterMode.ValueMember = "Value";

            lblUserEmpName.Text = Program.us.CurEmp.Name;
        }

        #region Methods

        private void displayEmpEditPanel()
        {
            String Editting = txtEmpName.Text + txtEmpRole.Text +
                txtEmpPhone.Text + cbbEmpSex.SelectedValue +
                txtBirth.Text + txtDayIn.Text + txtAddress.Text;
            Employees OriEmp = empList.find(lblEmpID.Text);
            String Original = OriEmp.Name + OriEmp.Role +
                OriEmp.Phone + OriEmp.Sex + OriEmp.Birth.ToShortDateString() +
                OriEmp.DayIn.ToShortDateString() + OriEmp.Address;
            if (!Editting.Equals(Original))
            {
                pnlEditAction.Visible = true;
            }
            else
            {
                pnlEditAction.Visible = false;
            }
        }

        private void updateGridView(DataGridView thisGridView, List<Employees> source)
        {
            thisGridView.DataSource = null;
            thisGridView.Refresh();
            thisGridView.Update();
            thisGridView.DataSource = source;
        }

        private bool vaildDay(String dateString)
        {
            try
            {
                DateTime.Parse(dateString);
            }
            catch
            {
                MessageBox.Show("Sai định dạng ngày tháng, kiểm tra lại", "Lỗi");
                return false;
            }
            return true;
        }

        private void fillEmpInfo()
        {
            if (dgvEmployeesTable.SelectedRows.Count > 0)
            {
                Employees currentEmp = empList.EmpList[dgvEmployeesTable.SelectedRows[0].Index];

                lblEmpID.Text = currentEmp.Id;
                txtEmpName.Text = currentEmp.Name;
                txtEmpRole.Text = currentEmp.Role;
                txtEmpPhone.Text = currentEmp.Phone;

                Dictionary<String, String> sexItems = new Dictionary<String, String>();
                sexItems.Add("Nam", "male");
                sexItems.Add("Nữ", "female");
                cbbEmpSex.DataSource = new BindingSource(sexItems, null);
                cbbEmpSex.DisplayMember = "Key";
                cbbEmpSex.ValueMember = "Value";
                cbbEmpSex.SelectedValue = currentEmp.Sex;

                txtBirth.Text = currentEmp.Birth.ToShortDateString();
                txtDayIn.Text = currentEmp.DayIn.ToShortDateString();
                txtAddress.Text = currentEmp.Address;
            }
        }

        #endregion

        #region Events

        private void empMoreInfoAnimation(Object tsender, EventArgs te)
        {
            if(pnlLeftInfo.Location.X >= pnlLeft.Location.X)
            {
                if(pnlLeftInfo.Location.X > pnlLeft.Location.X)
                {
                    pnlLeftInfo.Location = pnlLeft.Location;
                }
                animationTimer.Tick -= empMoreInfoAnimation;
            }
            else
            {
                pnlLeftInfo.Location = new Point(pnlLeftInfo.Location.X+10 ,81);
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

        private void empNewShowAnimation(Object tsender, EventArgs te)
        {
            if (pnlAddEmp.Location.X >= pnlLeft.Location.X)
            {
                if (pnlAddEmp.Location.X > pnlLeft.Location.X)
                {
                    pnlAddEmp.Location = pnlLeft.Location;
                }
                animationTimer.Tick -= empNewShowAnimation;
            }
            else
            {
                pnlAddEmp.Location = new Point(pnlAddEmp.Location.X + 10, 81);
            }
        }

        private void empNewHideAnimation(Object tsender, EventArgs te)
        {
            if (pnlAddEmp.Location.X <= -pnlAddEmp.Width)
            {
                if (pnlAddEmp.Location.X < -pnlAddEmp.Width)
                {
                    pnlAddEmp.Location = new Point(-pnlAddEmp.Width, 81);
                }
                animationTimer.Tick -= empNewHideAnimation;
            }
            else
            {
                pnlAddEmp.Location = new Point(pnlAddEmp.Location.X - 10, 81);
            }
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += empMoreInfoAnimation;
        }

        private void btnempMoreInfoClose_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += empLessInfoAnimation;
            pnlEditAction.Visible = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            empList.loadFromDb();
            updateGridView(dgvEmployeesTable, empList.EmpList);
        }

        private void dgvEmployeesTable_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvEmployeesTable.SelectedRows.Count == 0)
            {
                btnMoreInfo.Visible= false;
                lblMoreInfo.Visible = false;
            }
            else
            {
                btnMoreInfo.Visible = true;
                lblMoreInfo.Visible = true;
            }

            fillEmpInfo();

            this.CancelButton = btnempMoreInfoClose;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(dgvEmployeesTable.SelectedRows[0].Index == dgvEmployeesTable.RowCount - 1)
            {
                dgvEmployeesTable.Rows[0].Selected = true;

            }
            else
            {
                dgvEmployeesTable.Rows[dgvEmployeesTable.SelectedRows[0].Index + 1].Selected = true;
            }
            txtEmpName.Focus();
            pnlEditAction.Visible = false;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (dgvEmployeesTable.SelectedRows[0].Index == 0)
            {
                dgvEmployeesTable.Rows[dgvEmployeesTable.RowCount - 1].Selected = true;
            }
            else
            {
                dgvEmployeesTable.Rows[dgvEmployeesTable.SelectedRows[0].Index - 1].Selected = true;
            }
            txtEmpName.Focus();
            pnlEditAction.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += empNewShowAnimation;

            Dictionary<String, String> sexItems = new Dictionary<String, String>();
            sexItems.Add("Nam", "male");
            sexItems.Add("Nữ", "female");
            cbbNewEmpSex.DataSource = new BindingSource(sexItems, null);
            cbbNewEmpSex.DisplayMember = "Key";
            cbbNewEmpSex.ValueMember = "Value";

        }

        private void btnAddEmpClose_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += empNewHideAnimation;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            String newEmpID = txtNewEmpID.Text;
            String newEmpName = txtNewEmpName.Text;
            String newEmpRole = txtNewEmpRole.Text;
            String newEmpPhone = txtNewEmpPhone.Text;
            String newEmpSex = cbbNewEmpSex.SelectedValue.ToString();
            DateTime newEmpBirth;
            if (vaildDay(txtNewEmpBirth.Text))
            {
                newEmpBirth = DateTime.Parse( txtNewEmpBirth.Text);
            }
            else { return; }

            DateTime newEmpDayIn;
            if (vaildDay(txtNewEmpDayIn.Text))
            {
                newEmpDayIn = DateTime.Parse(txtNewEmpDayIn.Text);
            }
            else { return; }
            String newEmpAddress = txtNewEmpAddress.Text;
            Employees newEmp = new Employees(newEmpID, newEmpName, newEmpAddress, newEmpSex, newEmpBirth,
                newEmpPhone, newEmpRole, newEmpDayIn);

            empList.add(newEmp);
            updateGridView(dgvEmployeesTable, empList.EmpList);
            txtNewEmpID.Text = txtNewEmpName.Text = txtNewEmpRole.Text = txtNewEmpBirth.Text =
                txtNewEmpDayIn.Text = txtNewEmpAddress.Text =txtNewEmpPhone.Text="";
            txtNewEmpID.Focus();
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            String message = "Chắc chắn muốn xóa nhân viên?";
            if(MessageBox.Show(message, "Thông báo", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                empList.remove(lblEmpID.Text);
                updateGridView(dgvEmployeesTable, empList.EmpList);
            }
            else { return; }

            if(dgvEmployeesTable.RowCount == 0)
            {
                animationTimer.Tick += empLessInfoAnimation;
            }
            pnlEditAction.Visible = false;
        }

        private void btnEditAccept_Click(object sender, EventArgs e)
        {
            Employees currentEmp = empList.find(lblEmpID.Text);
            currentEmp.Name =txtEmpName.Text;
            currentEmp.Role =txtEmpRole.Text;
            currentEmp.Phone =txtEmpPhone.Text;
            currentEmp.Sex =cbbEmpSex.SelectedValue.ToString();
            if (vaildDay(txtBirth.Text))
            {
                currentEmp.Birth = DateTime.Parse(txtBirth.Text);
            }

            if (vaildDay(txtDayIn.Text))
            {
                currentEmp.DayIn = DateTime.Parse(txtDayIn.Text);
            }
            currentEmp.Address =txtAddress.Text;

            empList.ModifiedId.Add(lblEmpID.Text);

            updateGridView(dgvEmployeesTable, empList.EmpList);
            pnlEditAction.Visible = false;
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            fillEmpInfo();
            pnlEditAction.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            empList.saveChanges();
            MessageBox.Show("Đã lưu thay đổi vào csdl");
        }

        private void txtEmpName_KeyUp(object sender, KeyEventArgs e)
        {
            displayEmpEditPanel();
        }

        private void cbbEmpSex_Enter(object sender, EventArgs e)
        {
            displayEmpEditPanel();
        }

        #endregion

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            updateGridView(dgvEmployeesTable, empList.filter(txtFilter.Text, cbbFilterMode.SelectedValue.ToString()));
        }

        
    }
}
