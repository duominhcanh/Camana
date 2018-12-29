using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class frmDash : Form
    {
        private bool LoginStatus = false;
        public delegate void clickRecevie(object sender, EventArgs e);
        private event clickRecevie Logout_click;
        private Timer animationTimer = new Timer();

        public frmDash()
        {
            InitializeComponent();
            Logout_click += new clickRecevie(btnLogout_Click);
            frmDashWelcome1.clickCall = this.Logout_click;
            animationTimer.Interval = 2;
            animationTimer.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += slideIn;

            //Công việc cần làm để login thành công, sau đó đổi login status

            this.LoginStatus = true;
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            animationTimer.Tick += slideOut;

            //Công việc khi logout, , sau đó đổi login status

            this.LoginStatus = false;
        }

        private void slideIn(object Sender, EventArgs e)
        {
            if (frmDashWelcome1.Location.X < 0 && this.LoginStatus)
            {
                frmDashWelcome1.Location = new Point(
                    frmDashWelcome1.Location.X + 15, frmDashWelcome1.Location.Y);

                if (pnlTitle.Location.Y > 12)
                {
                    pnlTitle.Location = new Point(
                        pnlTitle.Location.X, pnlTitle.Location.Y - 10);
                }

                if (pnlMenu.Location.X > 235)
                {
                    pnlMenu.Location = new Point(
                        pnlMenu.Location.X - 40, pnlMenu.Location.Y);
                }

            }
            else
            {
                animationTimer.Tick -= slideIn;
            }
        }

        private void slideOut(object Sender, EventArgs e)
        {
            if (frmDashWelcome1.Location.X > -(frmDashWelcome1.Size.Width) && !this.LoginStatus)
            {
                frmDashWelcome1.Location = new Point(
                    frmDashWelcome1.Location.X - 15, frmDashWelcome1.Location.Y);

                if (pnlTitle.Location.Y < 120)
                {
                    pnlTitle.Location = new Point(
                        pnlTitle.Location.X, pnlTitle.Location.Y + 10);
                }

                if (pnlMenu.Location.X < this.Width)
                {
                    pnlMenu.Location = new Point(
                        pnlMenu.Location.X + 40, pnlMenu.Location.Y);
                }
            }
            else
            {
                animationTimer.Tick -= slideOut;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            this.Visible = true;
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmStorage StorageWindows = new frmStorage();
            StorageWindows.ShowDialog();
            this.Visible = true;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            this.Visible = true;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            this.Visible = true;
        }

        private void frmDash_Load(object sender, EventArgs e)
        {

        }
    }
}
