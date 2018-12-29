using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class frmDashWelcome : UserControl
    {
        public Delegate clickCall;

        public frmDashWelcome()
        {
            InitializeComponent();
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            object[] arr = { null, null };
            clickCall.DynamicInvoke(arr);
        }
    }
}
