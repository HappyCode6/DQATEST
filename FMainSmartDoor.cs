using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DQATEST
{
    public partial class FMainSmartDoor : UIForm
    {
        public FMainSmartDoor()
        {
            InitializeComponent();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            richTBLog.Text = "";
            richTBLog.ScrollToCaret();
            UIMessageTip.ShowOk("Clear Log OK", 1000, true);
        }

        private void btnShowAllDevices_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDetailSmartDoor fdetails = new FDetailSmartDoor();
            fdetails.ShowDialog();
            this.Show();
        }
    }
}
